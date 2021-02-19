using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido : MonoBehaviour
{
    public static sonido instance;

    // Sound events

    public AudioSource fuente1;
    public AudioSource fuente2;
    public AudioSource fuente3;
    public AudioSource fuente4;
    public AudioSource fuente5;
    public AudioSource fuente6;
    public AudioSource fuente7;
    public AudioSource fuente8;
    public AudioSource fuente9;
    public AudioSource fuente10;
    public AudioSource fuente11;

    public AudioClip clipPapel;
    public AudioClip clipCarpeta;
    public AudioClip clipLupa;
    public AudioClip clipContainerLargo;
    public AudioClip clipLapiz;
    public AudioClip clipYes;
    public AudioClip clipNoo;
    public AudioClip finaldiaperf;
    public AudioClip finaldia1F;
    public AudioClip finaldia2F;

    // Menu sound

    //public AudioSource fuente11;
    //public AudioSource fuente12;
    //public AudioSource fuente13;
    //public AudioSource fuente14;
    //public AudioSource fuente15;
    //
    //public AudioClip MenuSound1;
    //public AudioClip MenuSound2;
    //public AudioClip MenuSound3;
    //public AudioClip MenuSound4;
    //public AudioClip MenuSound5;

    // Soundtrack

    public AudioSource fuente20;
    public AudioClip musicBackground1;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        fuente1.clip = clipPapel;
        fuente2.clip = clipCarpeta;
        fuente3.clip = clipLupa;
        fuente4.clip = clipContainerLargo;
        fuente5.clip = clipContainerLargo;
        fuente6.clip = clipLapiz;
        fuente7.clip = clipYes;
        fuente8.clip = clipNoo;

        fuente9.clip = finaldiaperf;
        fuente10.clip = finaldia1F;
        fuente11.clip = finaldia2F;

        //fuente11.clip = MenuSound1;
        //fuente12.clip = MenuSound2;
        //fuente13.clip = MenuSound3;
        //fuente14.clip = MenuSound4;
        //fuente15.clip = MenuSound5;

        fuente20.clip = musicBackground1;
        PlayMusicaFondo();

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

    public void ReproducirLapiz()
    {
        fuente6.Play();
    }

    public void ReproducirYes()
    {
        fuente7.Play();
    }

    public void ReproducirNoo()
    {
        fuente8.Play();
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

    public void PlayMusicfinaldiaperf()
    {
        fuente9.Play();
    }

    public void StopMusicfinaldia()
    {
        fuente9.Stop();
    }

    public void PlayMusicfinaldia1F()
    {
        fuente10.Play();
    }

    public void StopMusicfinaldia1F()
    {
        fuente10.Stop();
    }

    public void PlayMusicfinaldia2F()
    {
        fuente11.Play();
    }

    public void StopMusicfinaldia2F()
    {
        fuente11.Stop();
    }

    //public void ReproducirMenu1()
    //{
    //    fuente11.Play();
    //}
    //
    //public void ReproducirMenu2()
    //{
    //    fuente12.Play();
    //}
    //
    //public void ReproducirMenu3()
    //{
    //    fuente13.Play();
    //}
    //
    //public void ReproducirMenu4()
    //{
    //    fuente14.Play();
    //}
    //
    //public void ReproducirMenu5()
    //{
    //    fuente15.Play();
    //}
}
