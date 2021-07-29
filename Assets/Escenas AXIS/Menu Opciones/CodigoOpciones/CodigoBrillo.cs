using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodigoBrillo : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image panelBrillo;
    
    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("brillo", 0.5f); 
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b,slider.value);//el valor cuando el juego inicia rgb 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("brillo",sliderValue);//aca se guarda el valor nuevo cada vez que movamos el slider
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g,panelBrillo.color.b,slider.value);
    }
}
