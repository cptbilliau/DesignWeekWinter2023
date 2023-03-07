using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotScript : MonoBehaviour
{
    float rotationSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse2))
        {
            float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
            float YAxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;

            transform.Rotate(Vector3.down, XaxisRotation);
            transform.Rotate(Vector3.right, YAxisRotation);
        }
    }
 
}
