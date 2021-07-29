using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CodigoCalidad : MonoBehaviour
{
    public TMP_Dropdown dropdown; //componente creado en unity
    public int calidad;
    // Start is called before the first frame update
    void Start()
    {
        calidad = PlayerPrefs.GetInt("numeroDeCalidad", 3); //guardar un valor en unity y cuando lo usamos se cambia
        dropdown.value = calidad;
        AjustarCalidad();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AjustarCalidad()
    {
        QualitySettings.SetQualityLevel((dropdown.value));//va a cambiar los valores de quality 
        PlayerPrefs.SetInt("numeroDeCalidad",dropdown.value);//cuando ya cambio el valor se guardara el valor
        calidad = dropdown.value;//cambiando el nombre
    }
}
