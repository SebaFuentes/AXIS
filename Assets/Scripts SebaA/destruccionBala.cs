using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruccionBala : MonoBehaviour
{
    //POR QUÉ ESTE CÓDIGO??
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Bala"))
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Bala"))
        {
            Destroy(collision.gameObject);
        }
    }
}
