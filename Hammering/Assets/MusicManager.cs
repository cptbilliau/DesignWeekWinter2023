using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Audio;
using E7.Introloop;



public class MusicManager : MonoBehaviour
{
    [Header("Music Trackers")]
    public float beatTime;
    public float beatCount;
    public float measureTime = 0;
    public float songTime;
    public float measureCount;
    public float measureLength = 1.20f;
    public bool songPlaying = false;
    [Header("Actual Music")]
    public IntroloopPlayer player;
    public IntroloopAudio song;
    [Header("Anvil SFX")]
    public AudioSource anvilC;
    public AudioSource anvilD;
    public AudioSource anvilE;
    public AudioSource dudAnvilC;
    public AudioSource dudAnvilD;
    public AudioSource dudAnvilE;




    // Start is called before the first frame update
    void Start()
    {
       
        player.Play(song);
        measureCount = 1;
        beatCount = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("h"))
        {
            anvilHit();
        }
        //remove these later????
        if (Input.GetKeyUp("d"))
        {
            anvilDud();
        }




        beatTime += Time.deltaTime;
            measureTime += Time.deltaTime;
            songTime += Time.deltaTime;


        if(beatTime >= 0.3)
        {
            if(beatCount == 1 || beatCount == 2 || beatCount == 3)
            {
                beatCount++;
                beatTime = 0;
            }else if(beatCount == 4)
            {
                beatCount = 1;
                beatTime = 0;
                addMeasure();
            }

        }

            //if (measureTime >= measureLength)
            //{
            //    measureTime = 0;
            //    addMeasure();
            //}
        

        

    }


    void addMeasure()
    {

        if(measureCount == 4)
        {
            measureCount = 1;
        }else if(measureCount == 3)
        {
            measureCount++;
        }
        else if (measureCount == 2)
        {
            measureCount++;
        }
        else if (measureCount == 1)
        {
            measureCount++;
        }


    }

    void anvilHit()
    {
        int rando = Random.Range(1, 4);

        if (rando == 1)
        {
            anvilC.Play();
        }else if(rando == 2 || rando == 4)
        {
            anvilD.Play();
        }else if(rando == 3)
        {
            anvilE.Play();
        }
    }
    void anvilDud()
    {

        int rando = Random.Range(1, 4);

        if (rando == 1)
        {
            dudAnvilC.Play();
        }
        else if (rando == 2 || rando == 4)
        {
            dudAnvilD.Play();
        }
        else if (rando == 3)
        {
            dudAnvilE.Play();
        }
    }

}
