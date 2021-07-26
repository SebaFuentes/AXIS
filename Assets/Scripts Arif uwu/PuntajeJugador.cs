using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PuntajeJugador : MonoBehaviour
{
    //Score por jugador
    public int score;
    public Text TXTscore;
    private int i;

    void Update()
    {

        TXTscore.text = "Score: " + score;
    }

    private void OnTriggerEnter2D(Collider2D collision) //SI LA NAVE COLISIONA CON METEORITO || NAVE || MONEDA
    {

        if (collision.CompareTag(tag: "Enemigo")) // ENEMIGO
        {
            score -= 3;
        }
        else if (collision.CompareTag(tag: "Meteorito")) //Meteorito
        {
            score -= 2;
        }
        else if (collision.CompareTag(tag:"Coin")) //MONEDA
        {
            score += 3;
        }

        for (i = 0; i < transform.childCount-1; i++) //cuento el total de hijos y 1 por 1 comparo
        {
            if (collision.gameObject.transform.GetChild(i).CompareTag(tag:"Meteorito"))
            {
                score += 3;
            }
            if (collision.gameObject.transform.GetChild(i).CompareTag(tag:"Enemigo"))
            {
                score += 5;
            }
        }
        
    }
}
