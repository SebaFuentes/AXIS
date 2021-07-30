using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinsManager : MonoBehaviour
{
    private void Update()
    { 
        AllCoinsCollected(); //llama todo el tiempo a esta rutina
    }

    /**
     * Este procedimiento verifica si quedan monedas, si no quedan pues pasa de nivel.
     */
    public void AllCoinsCollected()
    {
        if (transform.childCount == 0)
        {
          Debug.Log("Victoria, no quedan mas monedas");
          Time.timeScale = 0;
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }
}
