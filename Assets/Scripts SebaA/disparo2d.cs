using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disparo2d : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidad_disparo;

    private Vector3 posiscionPasada;
    
       
       // Start is called before the first frame update
       void Start()
       {
           rb = GetComponent<Rigidbody2D>();
   
           rb.velocity = transform.up * velocidad_disparo;
           posiscionPasada = transform.position;
       }
   
       // Update is called once per frame
       void Update()
       {
           if (posiscionPasada!=transform.position)
           {
               transform.up = transform.position - posiscionPasada;
               posiscionPasada = transform.position;
           }
           
      }
      
      //Score por jugador
      private void OnTriggerEnter2D(Collider2D collision)
      {
          if (collision.gameObject.tag == "Meteorito")
          {
              GameObject player = GameObject.Find ("NaveJugador");
              if (player != null) {
                  player.GetComponent<MovimientoJugador>().updateScore(5);
                //  Destroy (gameObject);
              }
          }
          if (collision.gameObject.tag == "Enemigo")
          {
              GameObject player = GameObject.Find ("NaveJugador");
              if (player != null) {
                  player.GetComponent<MovimientoJugador>().updateScore(10);
                //  Destroy (gameObject);
              }
          }
      }
}
