using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruccionMateoro : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Meteorito"))
        {
            Destroy(collision.gameObject);
            PuntajeJugador.score += 3;
        }

        if (collision.transform.CompareTag("Enemigo"))
        {
            Destroy(collision.gameObject);
            PuntajeJugador.score += 4;
        }

        if (collision.transform.CompareTag("Destruible"))
        {
            Destroy(collision.gameObject);
        }
    }
}
