using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador2 : MonoBehaviour
{
    public GameObject proyectil;
    private float distancia;
    private InputMaster controles;

    private void Awake()
    {
        controles = new InputMaster();
    }

    private void OnEnable()
    {
        controles.Enable();
    }

    private void OnDisable()
    {
        controles.Disable();
    }

    void Start()
    {
        controles.Jugador2.Disparo.performed += ctx => disparo();
    }
    
    void FixedUpdate()
    {
        
    }

    private void disparo()
    {
        Instantiate(proyectil, transform.position, transform.rotation);
    }
}
