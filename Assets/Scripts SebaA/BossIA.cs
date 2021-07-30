using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossIA : MonoBehaviour
{
    public VidaJefe vida;
    public float VidaMaxima = 200;
    public float Vida = 200;

    private void Start()
    {
        vida.setHealth(Vida,VidaMaxima);
    }

    private void Update()
    {
        
        if (Vida <= 0)
        {
            
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bala"))
        {
            Vida -= 5;
            vida.setHealth(Vida,VidaMaxima);
            Destroy(collision.gameObject);
        }
    }
}
