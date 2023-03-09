using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textCounter : MonoBehaviour
{
    public int hits;

    public Text totalText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            hits++;
        }

        totalText.text = "Total Hits:" + hits;


    }

    public void minusOne()
    {
        hits -= 1;
    }

    public void clearTotal()
    {
        hits = 0;
    }
}
