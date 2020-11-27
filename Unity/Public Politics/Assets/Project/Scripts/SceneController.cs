using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private int actualSceneNumero;

    public void loadScene(int numero)
    {
        SceneManager.LoadScene(numero);
    }

    public void loadScene(string sceneNombre)
    {
        SceneManager.LoadScene(sceneNombre);
    }
    
    
    private void UpdateNumero()
    {
        actualSceneNumero = SceneManager.GetActiveScene().buildIndex;
    }
    
}
