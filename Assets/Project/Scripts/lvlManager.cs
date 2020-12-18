using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class lvlManager : MonoBehaviour
{
    private int contadorContenedorDroga = 0;
    private int contadorContenedorLegales = 0;
    private int contadorContenedorRusia = 0;
    private int contadorContenedorColombia = 0;
    private int contadorContenedorAlemania = 0;
    private int contadorContenedorOtros = 0;


    public int time;
    public int dinero;
    public int vidas;   //se tiene que cambiar
    public int box;
    public TextMeshProUGUI dineroAmount;

    public bool tratoRusia;
    public bool tratoColombia;
    public bool tratoAlemania;
    public int trabajo;     // pasara a ser el valor correcto
    public int reputacionMafia1 = 50;
    public int reputacionMafia2 = 50;
    public int reputacionMafia3 = 50;



    public GameObject pantallaGameOver;
    public GameObject pantallaAviso;
    public GameObject finalMafia1Full;
    public GameObject finalMafia1Low;
    public GameObject finalMafia2Full;
    public GameObject finalMafia2Low;
    public GameObject finalMafia3Full;
    public GameObject finalMafia3Low;
    
    
    void Start()
    {
        if(vidas <= 0)
        {
            pantallaGameOver.SetActive(true);
        }
        else
        {
            pantallaGameOver.SetActive(false);
        }

}

    /*IEnumerator Esperar()
    {

        yield return new WaitForSeconds(0.3f);

    }*/

    void Update()
    {
        // Final vida >= 0
        if(vidas <= 0)
        {
            pantallaGameOver.SetActive(true);
            Debug.Log("gameover");
        }
        else
        {
            dineroAmount.text = "Dinero: " + dinero.ToString();
        }
        // Aviso low vida
        if (vidas == 2 && box != 6)
        {
            pantallaAviso.SetActive(true);
            vidas = 1;
        }
        // Finales repu FULL
        if (reputacionMafia1 <= 100)
        {
            finalMafia1Full.SetActive(true);
        }
        if (reputacionMafia2 <= 100)
        {
            finalMafia2Full.SetActive(true);
        }
        if (reputacionMafia3 <= 100)
        {
            finalMafia3Full.SetActive(true);
        }
        // Finales repu LOW
        if (reputacionMafia1 >= 0)
        {
            finalMafia3Low.SetActive(true);
        }
        if (reputacionMafia1 >= 0)
        {
            finalMafia1Low.SetActive(true);
        }
        if (reputacionMafia1 >= 0)
        {
            finalMafia1Low.SetActive(true);
        }
    }

    public void Reputacion(Button button)   //reputacionRusia reputacionColombia reputacionAlemania
    {
        // mafia 1
        if (box == 6 || box == 11 || box == 16 || box == 23 )
        {
            if (button.name == "AceptarButton")
            {
                reputacionMafia1 += 30;
                reputacionMafia2 -= 10;
                reputacionMafia3 -= 10;
                Debug.Log("reputacionRusia");
            }
            if (button.name == "DenegarButton")
            {
                reputacionMafia1 -= 75;
                Debug.Log("-75 dinero");
            }

        }

        // mafia 2
        if (box == 8 || box == 14 || box == 18 || box == 19 )
        {
            if (button.name == "AceptarButton")
            {
                reputacionMafia2 += 50;
                Debug.Log("+50 dinero");
            }
            if (button.name == "DenegarButton")
            {
                reputacionMafia2 -= 75;
                Debug.Log("-75 dinero");
            }

        }

        // mafia 3
        if (box == 10 || box == 13 || box == 21 || box == 24 )
        {
            if (button.name == "DenegarButton")
            {
                reputacionMafia2 += 50;
            }
            if (button.name == "AceptarButton")
            {
                reputacionMafia2 -= 75;
            }

        }
    }

    public void NextBox(Button button)
    {
        if(box == 1 || box == 2 || box == 3 || box == 6 || box == 8 || box == 10)
        {
            if(button.name == "AceptarButton")
            {
                dinero += 50;
                Debug.Log("+50 dinero");
            }
            if (button.name == "DenegarButton")
            {
                dinero -= 75;
                Debug.Log("-75 dinero");
            }
            
        }

        if (box == 4 || box == 5 || box == 7 || box == 9 || box == 10)
        {
            if (button.name == "DenegarButton")
            {
                dinero += 50;
            }
            if (button.name == "AceptarButton")
            {
                dinero -= 75;
            }
            
        }
        box++;

    }



    

}
