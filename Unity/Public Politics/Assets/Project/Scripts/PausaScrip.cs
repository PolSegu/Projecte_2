using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PausaScrip : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject pausaJuego;


    void Start()
    {
        pausaJuego.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pausaJuego.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
    }

    void Pause()
    {
        pausaJuego.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
    }
}
