using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PuntajeJugador : MonoBehaviour
{
    //Score por jugador
    public static int score;
    public Text TXTscore;
    private int i;

    void Update()
    {
        TXTscore.text = "Score: " + score;
        if(score <=0)
        {
            score = 0;
        }
    }
}
