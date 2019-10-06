using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;

    public AudioSource musicSource;

    public AudioClip musicClipOne;

    public AudioClip musicClipTwo;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //Handles the walking change state
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetInteger("State", 1);

            //handles first audio for walking
            musicSource.clip = musicClipOne;
            musicSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetInteger("State", 0);

            //stops music when key is let go
            musicSource.Stop();
        }

        //Handles the running change state
        if (Input.GetKeyDown(KeyCode.R))
        {
            anim.SetInteger("State", 2);

            //Handles second audio for running
            musicSource.clip = musicClipTwo;
            musicSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            anim.SetInteger("State", 0);

            //stops music when let go
            musicSource.Stop();
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }


    }
}
