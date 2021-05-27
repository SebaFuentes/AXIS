using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class MenuPausa : MonoBehaviour
{
    private InputMaster controles;
    public static bool JuegoEnPausa = false;
    [SerializeField]
    private GameObject CanvasMenu;

    private void Awake()
    {
        controles = new InputMaster();
    }

    private void OnEnable()
    {
        controles.Enable();
    }

    private void OnDisable()
    {
        controles.Disable();
    }

    private void Start()
    {
        controles.Menu.Menupausa.performed += _ => Pausa();
    }

    private void Pausa()
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
    private void ResumeGame()
    {
        CanvasMenu.SetActive(false);
        Time.timeScale = 1f;
        JuegoEnPausa = false;
    }

    private void PauseGame()
    {
        CanvasMenu.SetActive(true);
        Time.timeScale = 0f;
        JuegoEnPausa = true;
    }
}
