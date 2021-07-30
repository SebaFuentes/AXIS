using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public float speed;
    public float lineOfSite;
    
    private Transform player;
    void Start()
    {
        //Busca al jugador
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
    void Update()
    {
        //Determina la distancia hacia el jugador
        float distanceFromPlayer = Vector2.Distance(player.position,transform.position);
        if (distanceFromPlayer < lineOfSite)
        {
            transform.position = Vector2.MoveTowards(this.transform.position,player.position,speed*Time.deltaTime);
        }
    }

    //Determina el radio de deteccion del enemigo
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position,lineOfSite);
    }
}

