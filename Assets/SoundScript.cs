using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundScript : MonoBehaviour
{
    public AudioClip honk;
    AudioSource aS;

    public AudioSource music;

    // Start is called before the first frame update
    void Start()
    {
        aS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            PlaySound(0);
        if (Input.GetKeyDown(KeyCode.S))
            PlaySound(1);
        if (Input.GetKeyDown(KeyCode.X))
            PlaySound(2);
        if (Input.GetKeyDown(KeyCode.D))
            PlaySound(3);
        if (Input.GetKeyDown(KeyCode.C))
            PlaySound(4);
        if (Input.GetKeyDown(KeyCode.V))
            PlaySound(5);
        if (Input.GetKeyDown(KeyCode.G))
            PlaySound(6);
        if (Input.GetKeyDown(KeyCode.B))
            PlaySound(7);
        if (Input.GetKeyDown(KeyCode.H))
            PlaySound(8);
        if (Input.GetKeyDown(KeyCode.N))
            PlaySound(9);
        if (Input.GetKeyDown(KeyCode.J))
            PlaySound(10);
        if (Input.GetKeyDown(KeyCode.M))
            PlaySound(11);
        if (Input.GetKeyDown(KeyCode.K))
            PlaySound(12);
        if (Input.GetKeyDown(KeyCode.Comma))
            PlaySound(13);
        if (Input.GetKeyDown(KeyCode.Period))
            PlaySound(14);

        if (Input.GetKeyDown(KeyCode.I))
            PlaySound(0);
        if (Input.GetKeyDown(KeyCode.U))
            PlaySound(-1);
        if (Input.GetKeyDown(KeyCode.Alpha7))
            PlaySound(-2);
        if (Input.GetKeyDown(KeyCode.Y))
            PlaySound(-3);
        if (Input.GetKeyDown(KeyCode.Alpha6))
            PlaySound(-4);
        if (Input.GetKeyDown(KeyCode.T))
            PlaySound(-5);
        if (Input.GetKeyDown(KeyCode.Alpha5))
            PlaySound(-6);
        if (Input.GetKeyDown(KeyCode.R))
            PlaySound(-7);
        if (Input.GetKeyDown(KeyCode.E))
            PlaySound(-8);
        if (Input.GetKeyDown(KeyCode.Alpha3))
            PlaySound(-9);
        if (Input.GetKeyDown(KeyCode.W))
            PlaySound(-10);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            PlaySound(-11);
        if (Input.GetKeyDown(KeyCode.Q))
            PlaySound(-12);



        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (music.isPlaying)
                music.Pause();
            else
                music.UnPause();
        }
       
    }

    void PlaySound(float steps)
    {
        aS.pitch = 1 * Mathf.Pow(1.05946f, steps);
        aS.PlayOneShot(honk);
    }
}
