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
    public int vidas;
    public int box;
    public TextMeshProUGUI dineroAmount;
    public GameObject pantallaGameOver;
    public GameObject pantallaAviso;

    public bool tratoRusia;
    public bool tratoColombia;
    public bool tratoAlemania;
    public int trabajo;
    public int reputacionRusia;
    public int reputacionColombia;
    public int reputacionAlemania;



    GameObject FinalBueno;
    GameObject GameOver;
    
    
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
        if(vidas <= 0)
        {
            pantallaGameOver.SetActive(true);
            Debug.Log("gameover");
        }
        else
        {
            dineroAmount.text = "Dinero: " + dinero.ToString();
        }

        if (vidas == 2 && box != 6)
        {
            pantallaAviso.SetActive(true);
            vidas = 1;
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
