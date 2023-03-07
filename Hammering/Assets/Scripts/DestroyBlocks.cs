using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlocks : MonoBehaviour
{
    public GameObject DestroyCollider;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Mousepos = Input.mousePosition;
        Mousepos.z = 10f;
        Mousepos = cam.ScreenToWorldPoint(Mousepos);
        Debug.DrawRay(transform.position, Mousepos - transform.position, Color.blue);
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {

                Instantiate(DestroyCollider, hit.point, Quaternion.identity);
                Debug.Log(hit.transform.position);



            }
        }
    }
}
