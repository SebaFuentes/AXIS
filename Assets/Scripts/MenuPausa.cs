using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPausa : MonoBehaviour
{
    private InputMaster controles;
    public static bool JuegoEnPausa = false;
    public GameObject PauseMenuUI;
    
    
    void Update()
    {
        bool pausa = controles.Menu.Menupausa.triggered;
        if (pausa)
        {
            if (JuegoEnPausa)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    

    private void ResumeGame()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        JuegoEnPausa = false;
    }

    private void PauseGame()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        JuegoEnPausa = true;
    }
}
