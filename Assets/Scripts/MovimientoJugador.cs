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
    
    private Vector2 input;
    private float shipAngle;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        VidaTexto.text = "Vida: " + Vida;
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        if (input.x!=0 || input.y!=0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        VidaTexto.text = "Vida: " + Vida;
    }

    private void FixedUpdate()
    {
        rb.velocity = input * speed * Time.fixedDeltaTime;
        GetRotation();
    }

    void GetRotation()
    {
        Vector2 lookDir = new Vector2(-input.x, input.y);
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
        if (collision.gameObject.tag == "Meteorito")
        {
            Vida -= 10;
            Destroy(collision.gameObject);
        }
    }
}
