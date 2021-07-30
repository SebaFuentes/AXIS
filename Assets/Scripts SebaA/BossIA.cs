using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossIA : MonoBehaviour
{
    //Variables del jefe
    public VidaJefe vida;
    public float VidaMaxima = 200;
    public float Vida = 200;

    private void Start()
    {
        //Crea la barra de vida
        vida.setHealth(Vida,VidaMaxima);
    }

    private void Update()
    {
        //Si el jefe se queda sin vida
        if (Vida <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Detecta cuando lo impacta un disparo del jugador
        if (collision.CompareTag("Bala"))
        {
            Vida -= 5;
            vida.setHealth(Vida,VidaMaxima);
            Destroy(collision.gameObject);
        }
    }
}
