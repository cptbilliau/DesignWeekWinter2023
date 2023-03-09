using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlocks : MonoBehaviour
{
    public GameObject DestroyCollider;

    public float heatLevel = 100;
    public float brittleLevel = 0;
    public float heatCoolingSpeed = 4.0f;

    Camera cam;
    [SerializeField]
    bool isCharging;
    [SerializeField]
    public float chargeTimer;
    public GameObject burst;
    public GameObject dudBurst;
    [SerializeField]
    bool goingDown;
    float colliderSize;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        
    }


    // Update is called once per frame
    void Update()
    {
        if (heatLevel >= 0)
        {
            heatLevel -= heatCoolingSpeed * Time.deltaTime / 2;
        }

        if (heatLevel <= 0)
        {
            Debug.Log("Metal is cold");
        }

        Vector3 Mousepos = Input.mousePosition;
        Mousepos.z = 10f;
        Mousepos = cam.ScreenToWorldPoint(Mousepos);
        Debug.DrawRay(transform.position, Mousepos - transform.position, Color.blue);

        //if (heatLevel >= 0)
        //{
            switch (chargeTimer)
            {
                case > 0 and <= 0.5f:
                    colliderSize = 0.05f;
                    break;
                case > 0.5f and <= 1f:
                    colliderSize = 0.2f;
                    break;
                case > 1f and <= 1.5f:
                    colliderSize = 0.4f;
                    break;
                case > 1.5f and <= 2f:
                    colliderSize = 0.6f;
                    break;
            }



            if (Input.GetMouseButtonDown(0))
            {
                isCharging = true;
            }

            if (Input.GetMouseButtonUp(0))
            {


                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100))
                {
                    if (heatLevel <= 0)
                    {
                        GameObject dudParticle = Instantiate(dudBurst, hit.point, Quaternion.identity);
                        dudParticle.transform.localScale = new Vector3(colliderSize, colliderSize, colliderSize);
                        isCharging = false;
                    GetComponent<MusicManager>().anvilDud();


                }//if hit when dud, spawn new particles
                else
                    {


                        //instantiate the collider
                        GameObject newObject = Instantiate(DestroyCollider, hit.point, Quaternion.identity);
                        newObject.transform.localScale = new Vector3(colliderSize, colliderSize, colliderSize);

                        //instantiate the particle effects
                        GameObject particle = Instantiate(burst, hit.point, Quaternion.identity);
                        particle.transform.localScale = new Vector3(colliderSize, colliderSize, colliderSize);


                        //sound effect plays
                        GetComponent<MusicManager>().anvilHit();

                        isCharging = false;

                        Debug.Log(hit.transform.position);
                    }


                }
            }

            if (isCharging == true)
            {

                if (chargeTimer <= 0)
                {

                    goingDown = false;
                }

                if (chargeTimer >= 2)
                {
                    goingDown = true;
                }

                if (goingDown == true)
                {
                    chargeTimer -= 2.0f * Time.deltaTime;
                }

                if (goingDown == false)
                {
                    chargeTimer += 1.0f * Time.deltaTime;
                }
            }
            if (isCharging == false)
            {

                chargeTimer = 0;
                goingDown = false;
            }
        //}

        //else
        //{
        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        Debug.Log("The metal is too cold to shape!");
        //        //music plays
        //        GetComponent<MusicManager>().anvilDud();
        //    }
        //}
    }

    public void HeatButtonClick()
    {

        if (brittleLevel <= 2)
        {
            Debug.Log("Heat Button Message Recieved");
            heatLevel = 100;
            GetComponent<MusicManager>().forgeSFX();
        }
        else
        {

            Debug.Log("Metal too brittle");
          //  GetComponent<MusicManager>().anvilDud();

        }
    }
}
