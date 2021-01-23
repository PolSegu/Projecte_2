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
}
