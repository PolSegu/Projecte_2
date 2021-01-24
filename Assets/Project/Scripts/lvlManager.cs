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
    public int fallo = 0;
    public int vidas = 3;   // no se debe usar => done
    public int box;
    public TextMeshProUGUI dineroAmount;

    public bool tratoRusia;
    public bool tratoColombia;
    public bool tratoAlemania;
    // public int trabajo;     // pasara a ser el valor correcto => done
    public int reputacionMafia1 = 50;
    public int reputacionMafia2 = 50;
    public int reputacionMafia3 = 50;

    public GameObject finalDiaperf;
    public GameObject finalDia1F;
    public GameObject finalDia2F;

    public GameObject respuestaIncorrecta;
    public GameObject respuestaCorrecta;


    public GameObject pantallaGameOver;
    public GameObject pantallaAviso;
    public GameObject finalMafia1Full;
    public GameObject finalMafia1Low;
    public GameObject finalMafia2Full;
    public GameObject finalMafia2Low;
    public GameObject finalMafia3Full;
    public GameObject finalMafia3Low;

    public GameObject presentacionMafi1;
    public GameObject presentacionMafi2;
    public GameObject presentacionMafi3;



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

    void Update()
    {
        // Aviso 
        if (vidas == 2 )
        {
            //pantallaAviso.SetActive(true);            // De momento lo dejo fuera
            vidas = 1;
        }
        // Final gameover
        if (vidas == 0)
        {
            pantallaGameOver.SetActive(true);
            Debug.Log("gameover");
        }

        // Finales repu FULL
        if (reputacionMafia1 >= 100)
        {
            finalMafia1Full.SetActive(true);
        }
        if (reputacionMafia2 >= 100)
        {
            finalMafia2Full.SetActive(true);
        }
        if (reputacionMafia3 >= 100)
        {
            finalMafia3Full.SetActive(true);
        }

        // Finales repu LOW
        if (reputacionMafia1 <= 0)
        {
            finalMafia1Low.SetActive(true);
        }
        if (reputacionMafia2 <= 0)
        {
            finalMafia2Low.SetActive(true);
        }
        if (reputacionMafia3 <= 0)
        {
            finalMafia3Low.SetActive(true);
        }

    }

    public void Trabajo(Button button)
    {
        // mafia 1
        if (box == 6 || box == 12 || box == 15 || box == 20 || box == 27)
        {
            if (button.name == "AceptarButton")
            {
                reputacionMafia1 += 30;
                reputacionMafia2 -= 10;
                reputacionMafia3 -= 10;
                dinero += 100;

                contadorContenedorRusia++;
                contadorContenedorDroga++;
                Debug.Log("reputacionRusia-");
            }
            if (button.name == "DenegarButton")
            {
                reputacionMafia1 -= 10;
                reputacionMafia2 += 5;
                reputacionMafia3 += 5;
                Debug.Log("reputacionRusia+");
            }
        }

        // mafia 2
        if (box == 10 || box == 18 || box == 22)
        {
            if (button.name == "AceptarButton")
            {
                reputacionMafia1 -= 10;
                reputacionMafia2 += 30;
                reputacionMafia3 -= 10;
                dinero += 100;

                contadorContenedorColombia++;
                contadorContenedorDroga++;
                Debug.Log("reputacionColombia-");
            }
            if (button.name == "DenegarButton")
            {
                reputacionMafia1 += 5;
                reputacionMafia2 -= 10;
                reputacionMafia3 += 5;

                Debug.Log("reputacionColombia+");
            }
        }

        // mafia 3
        if (box == 25 || box == 28)
        {
            if (button.name == "AceptarButton")
            {
                reputacionMafia1 -= 10;
                reputacionMafia2 -= 10;
                reputacionMafia3 += 30;
                dinero += 100;

                contadorContenedorAlemania++;
                contadorContenedorDroga++;
                Debug.Log("reputacionAlemania-");
            }
            if (button.name == "DenegarButton")
            {
                reputacionMafia1 += 5;
                reputacionMafia2 += 5;
                reputacionMafia3 -= 10;
                Debug.Log("reputacionAlemania+");
            }
        }

        // Jefe buen contenedor
        if (box == 1 || box == 2 || box == 3 || box == 7 || box == 8 || box == 13 || box == 14 || box == 16 || box == 17 || box == 19 || box == 21 || box == 24 || box == 26 || box == 29)
        {
            if(button.name == "AceptarButton")
            {
                dinero += 25;
                Debug.Log("+25 dinero");
                respuestaCorrecta.SetActive(true);
            }
            if (button.name == "DenegarButton")
            {
                dinero -= 50;
                Debug.Log("-50 dinero");
                fallo++;
                respuestaIncorrecta.SetActive(true);
            }
        }
        // Jefe mal contenedor
        if (box == 4 || box == 5 || box == 6 || box == 9 || box == 10 || box == 11 || box == 12 || box == 15 || box == 18
            || box == 20 || box == 22 || box == 23 || box == 25 || box == 27 || box == 28)
        {
            if (button.name == "AceptarButton")
            {
                dinero -= 50;
                Debug.Log("-50 dinero");
                fallo++;
                respuestaIncorrecta.SetActive(true);
            }
            if (button.name == "DenegarButton")
            {
                dinero += 25;
                Debug.Log("+25 dinero");
                respuestaCorrecta.SetActive(true);
            }
        }

        box++;

        // Final dia

        if (box == 6 || box == 10 || box == 14 || box == 19 || box == 24)
        {
            if (fallo == 0)
            {
                finalDiaperf.SetActive(true);
                
            }

            if (fallo == 1)
            {
                finalDia1F.SetActive(true);
            }

            if (fallo < 1)
            {
                finalDia2F.SetActive(true);
            }

            if(box == 6)
            {
                presentacionMafi1.SetActive(true);
            }

            if (box == 10)
            {
                presentacionMafi2.SetActive(true);
            }

            if (box == 19)
            {
                presentacionMafi3.SetActive(true);
            }

            fallo = 0;
        }


        // Final vida >= 0
        if (dinero < 0)
        {
            vidas--;
            dinero = 50;
        }
        else             // No menrecordo de que feia F
        {
            dineroAmount.text = "Dinero: " + dinero.ToString();
        }
    }


}
