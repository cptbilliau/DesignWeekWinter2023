using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeTrigger : MonoBehaviour
{
    [SerializeField]
    DestroyBlocks destroyBlocks;
    Material material;

    public Gradient myGradient;
    public float strobeDuration = 2f;

    

    private void Start()
    {
        destroyBlocks = GameObject.Find("Main Camera").GetComponent<DestroyBlocks>();
        material = GetComponent<Renderer>().material;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collider")
        {
            Destroy(gameObject);
        }
    }
    public void Update()
    {
        
        material.color = myGradient.Evaluate(destroyBlocks.heatLevel/100);
        material.SetColor("_EmissionColor", myGradient.Evaluate(destroyBlocks.heatLevel/100));
    }
}
