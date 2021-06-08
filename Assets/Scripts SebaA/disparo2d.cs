using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo2d : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidad_disparo;

    private Vector3 posiscionPasada;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = transform.up * velocidad_disparo;
        posiscionPasada = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (posiscionPasada!=transform.position)
        {
            transform.up = transform.position - posiscionPasada;
            posiscionPasada = transform.position;
        }
    }
}
