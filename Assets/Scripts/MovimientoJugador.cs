using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovimientoJugador : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float rotationInterpolation = 0.4f;
    public bool isMoving;
    public TextMeshProUGUI VidaTexto;
    public int Vida = 100;
    
    private float shipAngle;
    private InputMaster controles;

    private void Awake()
    {
        controles = new InputMaster();
        rb = GetComponent<Rigidbody2D>();
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
        VidaTexto.text = "Vida: " + Vida;
    }

    // Update is called once per frame
    void Update()
    {
        VidaTexto.text = "Vida: " + Vida;
        if (Vida<=0)
        {
            Debug.Log("Has muerto");
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        Vector2 MoveInput = controles.Jugador1.Movimiento.ReadValue<Vector2>();
        rb.velocity = MoveInput * speed;
        if (MoveInput.x!=0 || MoveInput.y!=0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
        GetRotation();
    }

    void GetRotation()
    {
        Vector2 MoveInput = controles.Jugador1.Movimiento.ReadValue<Vector2>();
        Vector2 lookDir = new Vector2(-MoveInput.x, MoveInput.y);
        if (isMoving==true)
        {
            shipAngle = Mathf.Atan2(lookDir.x, lookDir.y)* Mathf.Rad2Deg;
        }
        
        if (rb.rotation<=-90 && shipAngle>=90)
        {
            rb.rotation += 360;
            rb.rotation = Mathf.Lerp(rb.rotation, shipAngle,rotationInterpolation);
        }
        else if (rb.rotation>=90 && shipAngle<=-90)
        {
            rb.rotation -= 360;
            rb.rotation = Mathf.Lerp(rb.rotation, shipAngle,rotationInterpolation);
        }
        else
        {
            rb.rotation = Mathf.Lerp(rb.rotation, shipAngle,rotationInterpolation);  
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Meteorito" || collision.gameObject.tag == "Enemigo")
        {
            Vida -= 10;
            Destroy(collision.gameObject);
        }
    }
}
