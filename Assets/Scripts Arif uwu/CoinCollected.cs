using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollected : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
   {
      if (collision.CompareTag("Player"))
      {
         GetComponent<SpriteRenderer>().enabled = false;  // desactiva el sprite de manzana
         gameObject.transform.GetChild(0).gameObject.SetActive(true); //activa el hijo collected en la posicion 0
         Destroy(gameObject, 0.5f); // destruye el objeto en 0,5 seg
      }
   }
}
