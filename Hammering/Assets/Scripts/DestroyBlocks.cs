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
    float chargeTimer;
    [SerializeField]
    bool goingDown;
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
            heatLevel -= heatCoolingSpeed * Time.deltaTime;
        }

        if (heatLevel <= 0)
        {
            Debug.Log("Metal is cold");
        }

        Vector3 Mousepos = Input.mousePosition;
        Mousepos.z = 10f;
        Mousepos = cam.ScreenToWorldPoint(Mousepos);
        Debug.DrawRay(transform.position, Mousepos - transform.position, Color.blue);

        if (heatLevel >= 0)
        {



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

                    GameObject newObject = Instantiate(DestroyCollider, hit.point, Quaternion.identity);
                    newObject.transform.localScale = new Vector3(chargeTimer, chargeTimer, chargeTimer);

                    isCharging = false;

                    Debug.Log(hit.transform.position);



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
        }

        else
        {
            if(Input.GetMouseButtonDown(0))
            Debug.Log("The metal is too cold to shape!");
        }
    }

    public void HeatButtonClick()
    {
        if (brittleLevel <= 2)
        {
            Debug.Log("Heat Button Message Recieved");
            heatLevel = 100;
            brittleLevel += 1.0f;
        }

        else
        {

            Debug.Log("Metal too brittle");
        }
    }
}
