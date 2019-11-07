using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundScript : MonoBehaviour
{
    public AudioClip honk;
    AudioSource aS;
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
    }

    void PlaySound(float steps)
    {
        aS.pitch = 1 * Mathf.Pow(1.05946f, steps);
        aS.PlayOneShot(honk);
    }
}
