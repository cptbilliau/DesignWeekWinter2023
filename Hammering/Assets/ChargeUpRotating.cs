using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeUpRotating : MonoBehaviour
{

    public Transform pivot;
    public GameObject Camera;

    public float smooth = 5f;

    public Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        scaleChange = new Vector3((Camera.GetComponent<DestroyBlocks>().chargeTimer / 3) + 1, (Camera.GetComponent<DestroyBlocks>().chargeTimer / 3) + 1, (Camera.GetComponent<DestroyBlocks>().chargeTimer / 3) + 1);

        Quaternion target = Quaternion.Euler(0, 0, (Camera.GetComponent<DestroyBlocks>().chargeTimer * -1) * 40);
        pivot.transform.localScale = scaleChange;
        pivot.rotation = Quaternion.Slerp(transform.rotation, target, 50);
    }
}
