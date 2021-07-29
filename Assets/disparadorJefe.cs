using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparadorJefe : MonoBehaviour
{
    public float tiempoDisparo, tiempo;
    public GameObject proyectil;

    private void FixedUpdate()
    {
        tiempo++;
        if (tiempoDisparo == tiempo)
        {
            disparo();
            tiempo = 0;
        }
    }

    private void disparo()
    {
        Instantiate(proyectil, transform.position, transform.rotation);
    }
}
