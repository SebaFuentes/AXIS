using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoJefe : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidad_disparo;

    private Vector3 posicionPasada;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = transform.up * velocidad_disparo;
        posicionPasada = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (posicionPasada!=transform.position)
        {
            transform.up = transform.position - posicionPasada;
            posicionPasada = transform.position;
        }
    }
}
