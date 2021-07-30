using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BossIA : MonoBehaviour
{
    public VidaJefe vida;
    public float VidaMaxima = 200;
    public float Vida = 200;
    public GameObject jugadorS;
    public GameObject multi;

    private void Start()
    {
        vida.setHealth(Vida,VidaMaxima);
    }

    private void Update()
    {
        if (Vida <= 0)
        {
            jugadorS.SetActive(true);
            multi.SetActive(true);
            Destroy(gameObject);
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
