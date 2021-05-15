using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparador : MonoBehaviour
{
    public GameObject proyectil;
    public float distancia;

    // Start is called before the first frame update
    void Start()
    {
        distancia = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Instantiate(proyectil, transform.position, transform.rotation);
        }
    }
}
