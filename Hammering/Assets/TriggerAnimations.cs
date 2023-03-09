using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimations : MonoBehaviour
{

    public Animator anim;

    public GameObject ingotMaker;

    public GameObject prefab;

    public GameObject spawnPoint;


    public void Start()
    {
        FindObjectOfType<Camera>().GetComponent<DestroyBlocks>().heatLevel = 100;

    }

    public void forgeActivate()
    {
        anim = GameObject.FindGameObjectWithTag("CUBE").GetComponent<Animator>();

        anim.SetTrigger("forge");
    }
    public void quenchActivate()
    {
        anim = GameObject.FindGameObjectWithTag("CUBE").GetComponent<Animator>();


        anim.SetTrigger("quench");
    }

    public void createNewCube()
    {
        FindObjectOfType<Camera>().GetComponent<spawnCube>().cubeMoment();


        Destroy(this.gameObject);


    }


    public void reheat()
    {
        FindObjectOfType<Camera>().GetComponent<DestroyBlocks>().HeatButtonClick();

    }


}
