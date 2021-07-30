using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iniciarPelea : MonoBehaviour
{
    public GameObject jugadorS;
    public GameObject multi;
    public GameObject boss;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            jugadorS.SetActive(false);
            multi.SetActive(false);
            boss.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
