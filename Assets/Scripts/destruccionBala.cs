using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruccionBala : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Bala"))
        {
            Debug.Log("Meteoro destruido");
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
