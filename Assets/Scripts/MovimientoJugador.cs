using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MovimientoJugador : MonoBehaviour
{
    //Fisicas y rotacion
    public Rigidbody2D rb;
    public float speed;
    public float rotationInterpolation = 0.4f;
    public bool isMoving;
    private float shipAngle;
    
    //Vida con texto
    public TextMeshProUGUI VidaTexto;
    public int Vida = 100;
    
    //Vida con corazones
    public Image Corazon;
    public int CantCorazones;
    public RectTransform posicionPrimerCorazon;
    public Canvas MyCanvas;
    public int OffSet;
    
    //Sistema de input
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
        //Muestra en pantalla la vida
        VidaTexto.text = "Vida: " + Vida;

        //Dibuja los corazones en pantalla
        Transform PosCorazon = posicionPrimerCorazon;
        for (int i = 0; i < CantCorazones; i++)
        {
            Image NewCorazon = Instantiate(Corazon,PosCorazon.position,Quaternion.identity);
            NewCorazon.transform.parent = MyCanvas.transform;
            PosCorazon.position = new Vector2(PosCorazon.position.x + OffSet, PosCorazon.position.y);
        }
    }
    
    void Update()
    {
        //Actualiza la cantidad de vida
        VidaTexto.text = "Vida: " + Vida;
        //Cuando la vida llega a 0
        if (Vida<=0)
        {
            Debug.Log("Has muerto");
            Destroy(gameObject);
        }
        
        //Cuando se queda sin corazones
        if (CantCorazones <= 0)
        {
            Destroy(gameObject);
            Destroy(Corazon);
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
            //Le resta vida al total
            Vida -= 10;
            
            //Le quita un corazon al activarse el collider
            Destroy(MyCanvas.transform.GetChild(CantCorazones + 1).gameObject);
            CantCorazones -= 1;
            
            //Destruye al meteorito/enemigo
            Destroy(collision.gameObject);
            
        }
    }
}
