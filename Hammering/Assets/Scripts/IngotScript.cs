using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngotScript : MonoBehaviour
{
    public int height;
    public int width;
    public int depth;
    float yOffset = 0.2f;
    float xOffset = 0.2f;
    float zOffset = 0.2f;
    
    [SerializeField]
    GameObject IngotPixel;
 
    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0; i <= width; i++)
        //{
        //    for (int j = 0; j <= height; j++)
        //    {
        //        for (int k = 0; k <= depth; k++)
        //        {
        //            Vector3 nextPos = new Vector3((i * yOffset) + transform.position.y, (j * xOffset) + transform.position.x, (k * zOffset) + transform.position.z);
        //            Instantiate(IngotPixel, nextPos, Quaternion.identity, transform);
        //            IngotPixel.tag = "ingot";
        //        }
        //    }
        //}


    }

    public void newCube()
    {
        foreach (var gameObj in GameObject.FindGameObjectsWithTag("ingot") as GameObject[])
        {
            Destroy(gameObj);
        }

        for (int i = 0; i <= width; i++)
        {
            for (int j = 0; j <= height; j++)
            {
                for (int k = 0; k <= depth; k++)
                {
                    Vector3 nextPos = new Vector3((i * yOffset) + transform.position.y, (j * xOffset) + transform.position.x, (k * zOffset) + transform.position.z);
                    Instantiate(IngotPixel, nextPos, Quaternion.identity, transform);
                }
            }
        }

    }
   
}
