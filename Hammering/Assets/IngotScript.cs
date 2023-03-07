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
        for (int i = 1; i <= width; i++)
        {
            for (int j = 1; j <= height; j++)
            {
                for (int k = 1; k <= depth; k++)
                {
                    Vector3 nextPos = new Vector3(transform.position.y + (i * yOffset), transform.position.x + (j * xOffset), transform.position.z + (k * zOffset));
                    Instantiate(IngotPixel, nextPos, Quaternion.identity, transform);
                }
            }
        }

        transform.position = new Vector3(-0.5f, 2.4f,0);
    }

}
