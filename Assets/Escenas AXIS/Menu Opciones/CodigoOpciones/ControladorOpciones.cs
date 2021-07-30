using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorOpciones : MonoBehaviour
{
    public GameObject pantallaOpciones;
    
    // Start is called before the first frame update
    public void abrirOpciones()
    {
        pantallaOpciones.SetActive(true);
    }
}
