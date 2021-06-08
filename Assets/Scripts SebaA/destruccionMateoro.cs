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
        }

        if (collision.transform.CompareTag("Enemigo"))
        {
            Destroy(collision.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
