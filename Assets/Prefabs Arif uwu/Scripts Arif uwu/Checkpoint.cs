using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    /**
     * este procedimiento realiza una comparacion con el tag player, en caso de estar colisionando,
     * le da al codigo de checkpoint las coordenadas para guardar los puntos x e y
     */
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<CheckPointPlayer>().ReachedCheckPoint(transform.position.x, transform.position.y);
        }
        
    }
}
