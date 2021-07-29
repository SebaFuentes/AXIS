using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodigoVolumen : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image imagenMute;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);//creando valor para guardar la posicion donde se encontro el slider
        AudioListener.volume = sliderValue;// el valor de 0.5 es justo al medio del slider para que al iniciar el juego siempre aparezca con ese volumen
        RevisarSiEstoyMute();
    }

    public void ChangeSlider(float valor)
    {
        sliderValue = valor;//el valor se saca del slider value en la barra
        PlayerPrefs.SetFloat("volumenAudio",sliderValue);//
        AudioListener.volume = slider.value;//sea el valor del sliderValue
        RevisarSiEstoyMute();//llamamos a la funcion para mostrar la imagen
    }

    public void RevisarSiEstoyMute()
    {
        if (sliderValue == 0)//revisa si el volumen se encuentra en 0
        {
            imagenMute.enabled = true;//activa una imagen de referencia si es true
        }
        else
        {
            imagenMute.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
