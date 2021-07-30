using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using  UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public float posicionx = -1.95f;
    public float posiciony = 0.04f;
    public GameObject player1, player2;

    public void VolverJuego( )
    {
       
        gameObject.SetActive(false);
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        
    }

    public void VolverMenu(String name)
    {
        SceneManager.LoadScene(name);
    }
}
