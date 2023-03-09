using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCube : MonoBehaviour
{



    public GameObject prefab;

    public GameObject spawnPoint;
    


    public void cubeMoment()
    {
            Instantiate(prefab, new Vector3(2.4f, 15f, 1f), Quaternion.identity);
            Debug.Log("CUBE MADE");
            
        
    }
}
