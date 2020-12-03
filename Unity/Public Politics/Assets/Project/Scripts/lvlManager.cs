using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class lvlManager : MonoBehaviour
{
    public int time;
    public int dinero;
    public int vidas;
    public int box;
    public TextMeshProUGUI dineroAmount;
    public GameObject pantallaGameOver;
    public GameObject pantallaAviso;

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
        if(box == 1 || box == 2 || box == 3 || box == 7 || box == 9)
        {
            if(button.name == "AceptarButton")
            {
                dinero += 100;
                Debug.Log("dinero");
            }
            if (button.name == "DenegarButton")
            {
                vidas--;
                Debug.Log("-Vida");
            }
            
        }

        if (box == 4 || box == 5 || box == 6 || box == 8 || box == 10)
        {
            if (button.name == "DenegarButton")
            {
                dinero += 100;
            }
            if (button.name == "AceptarButton")
            {
                vidas--;
            }
            
        }
        box++;

    }



    

}
