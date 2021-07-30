using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coincollected : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
        
    }
}
