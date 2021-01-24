using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido : MonoBehaviour
{
    // Sound events

    public AudioSource fuente1;
    public AudioSource fuente2;
    public AudioSource fuente3;
    public AudioSource fuente4;
    public AudioSource fuente5;

    public AudioClip clipPapel;
    public AudioClip clipCarpeta;
    public AudioClip clipLupa;
    public AudioClip clipContainerLargo;

    // Menu sound

    public AudioSource fuente11;
    public AudioSource fuente12;
    public AudioSource fuente13;
    public AudioSource fuente14;
    public AudioSource fuente15;

    public AudioClip MenuSound1;
    public AudioClip MenuSound2;
    public AudioClip MenuSound3;
    public AudioClip MenuSound4;
    public AudioClip MenuSound5;

    // Soundtrack

    public AudioSource fuente20;
    public AudioClip musicBackground1;
    
    // Start is called before the first frame update
    void Start()
    {
        fuente1.clip = clipPapel;
        fuente2.clip = clipCarpeta;
        fuente3.clip = clipLupa;
        fuente4.clip = clipContainerLargo;
        fuente5.clip = clipContainerLargo;

        fuente11.clip = MenuSound1;
        fuente12.clip = MenuSound2;
        fuente13.clip = MenuSound3;
        fuente14.clip = MenuSound4;
        fuente15.clip = MenuSound5;

        fuente20.clip = musicBackground1;
    }

    // Update is called once per frame
    public void ReproducirPapel()
    {
        fuente1.Play();
    }

    public void ReproducirCarpeta()
    {
        fuente2.Play();
    }

    public void ReproducirLupa()
    {
        fuente3.Play();
    }

    public void ReproducirContainerLargo()
    {
        fuente4.Play();
    }

    public void ReproducirContainerLargoVuelta()
    {
        fuente5.Play();
    }

    public void PlayMusicaFondo()
    {
        // Music Background

        fuente20.Play();

    }

    public void StopMusicaFondo()
    {
        // Music Background

        fuente20.Stop();

    }

    public void ReproducirMenu1()
    {
        fuente11.Play();
    }

    public void ReproducirMenu2()
    {
        fuente12.Play();
    }

    public void ReproducirMenu3()
    {
        fuente13.Play();
    }

    public void ReproducirMenu4()
    {
        fuente14.Play();
    }

    public void ReproducirMenu5()
    {
        fuente15.Play();
    }
}
