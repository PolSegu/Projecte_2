using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido : MonoBehaviour
{
    public AudioSource fuente1;
    public AudioSource fuente2;
    public AudioSource fuente3;

    public AudioClip clipPapel;
    public AudioClip clipCarpeta;
    public AudioClip clipLupa;

    // Start is called before the first frame update
    void Start()
    {
        fuente1.clip = clipPapel;
        fuente2.clip = clipCarpeta;
        fuente3.clip = clipLupa;
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
}
