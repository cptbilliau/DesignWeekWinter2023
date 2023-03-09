using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerController : MonoBehaviour
{

    public AudioSource hello1;
    public AudioSource hello2;
    public AudioSource hello3;

    public AudioSource thank1;
    public AudioSource thank2;
    public AudioSource thank3;

    public Animator anim;

    public Sprite person1;
    public Sprite person2;
    public Sprite person3;

    public void Start()
    {
        anim.GetComponent<Animator>();

        anim.SetTrigger("enter");
    }

    public void enterAnimation()
    {
        anim.GetComponent<Animator>();

        anim.SetTrigger("enter");
    }

    public void endAnimation()
    {
        anim.GetComponent<Animator>();

        anim.SetTrigger("end");

    }

    public void newSprite()
    {
        int rando = Random.Range(1, 4);

        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        if(rando == 1)
        {
            sr.sprite = person1;
        }else if (rando == 2)
        {
            sr.sprite = person2;
        }
        else if(rando == 3)
        {
            sr.sprite = person3;
        }


    }

    public void sayHello()
    {
        int rando = Random.Range(1, 4);

        if(rando == 1)
        {
            if(hello1.isPlaying != true)
            {
                hello1.Play();
            }
        }else if (rando == 2)
        {
            if (hello2.isPlaying != true)
            {
                hello2.Play();
            }
        }
        else if(rando == 3)
        {
            if (hello3.isPlaying != true)
            {
                hello3.Play();
            }
        }

    }

    public void sayGoodbye()
    {
        int rando = Random.Range(1, 4);

        if (rando == 1)
        {
            if (thank1.isPlaying != true)
            {
                thank1.Play();
            }
        }
        else if (rando == 2)
        {
            if (thank2.isPlaying != true)
            {
                thank2.Play();
            }
        }
        else if (rando == 3)
        {
            if (thank3.isPlaying != true)
            {
                thank3.Play();
            }
        }
    }


}
