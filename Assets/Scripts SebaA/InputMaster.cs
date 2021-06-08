// GENERATED AUTOMATICALLY FROM 'Assets/Scripts SebaA/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Jugador 1"",
            ""id"": ""fc063746-fb49-4bdd-a906-3ee8149a6a7e"",
            ""actions"": [
                {
                    ""name"": ""Movimiento"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f117bb35-f87d-4a81-a473-56a363d197da"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Disparo"",
                    ""type"": ""PassThrough"",
                    ""id"": ""587fe550-39b3-4f53-be55-b4d8328f5501"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""306e3bf0-9f01-462f-85ea-1ce345d07e2c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e6aee130-c3dd-451c-aee1-6b1fd6c8052a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1655502b-3d3a-443c-aadd-e102f2cac58e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""58deb929-c59e-4602-9984-5e3a3a264a3c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""99ebc819-5090-493b-a63a-726564d1b673"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""21821efc-2d96-4243-9bd7-360766b7edee"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Teclado y Mouse"",
                    ""action"": ""Disparo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""1ea61092-fcd4-4072-85cf-2f02d5ed5319"",
            ""actions"": [
                {
                    ""name"": ""Menu pausa"",
                    ""type"": ""Button"",
                    ""id"": ""71337a69-9206-4b5d-ab0e-c7f7a71201af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Navegacion Menu"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9c837b32-ba75-452b-8ef3-09b13aea986a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8f990f3e-ceb2-42a2-8dae-04075f951ee8"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Teclado y Mouse"",
                    ""action"": ""Menu pausa"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Teclado y Mouse"",
            ""bindingGroup"": ""Teclado y Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Jugador 1
        m_Jugador1 = asset.FindActionMap("Jugador 1", throwIfNotFound: true);
        m_Jugador1_Movimiento = m_Jugador1.FindAction("Movimiento", throwIfNotFound: true);
        m_Jugador1_Disparo = m_Jugador1.FindAction("Disparo", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Menupausa = m_Menu.FindAction("Menu pausa", throwIfNotFound: true);
        m_Menu_NavegacionMenu = m_Menu.FindAction("Navegacion Menu", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Jugador 1
    private readonly InputActionMap m_Jugador1;
    private IJugador1Actions m_Jugador1ActionsCallbackInterface;
    private readonly InputAction m_Jugador1_Movimiento;
    private readonly InputAction m_Jugador1_Disparo;
    public struct Jugador1Actions
    {
        private @InputMaster m_Wrapper;
        public Jugador1Actions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movimiento => m_Wrapper.m_Jugador1_Movimiento;
        public InputAction @Disparo => m_Wrapper.m_Jugador1_Disparo;
        public InputActionMap Get() { return m_Wrapper.m_Jugador1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Jugador1Actions set) { return set.Get(); }
        public void SetCallbacks(IJugador1Actions instance)
        {
            if (m_Wrapper.m_Jugador1ActionsCallbackInterface != null)
            {
                @Movimiento.started -= m_Wrapper.m_Jugador1ActionsCallbackInterface.OnMovimiento;
                @Movimiento.performed -= m_Wrapper.m_Jugador1ActionsCallbackInterface.OnMovimiento;
                @Movimiento.canceled -= m_Wrapper.m_Jugador1ActionsCallbackInterface.OnMovimiento;
                @Disparo.started -= m_Wrapper.m_Jugador1ActionsCallbackInterface.OnDisparo;
                @Disparo.performed -= m_Wrapper.m_Jugador1ActionsCallbackInterface.OnDisparo;
                @Disparo.canceled -= m_Wrapper.m_Jugador1ActionsCallbackInterface.OnDisparo;
            }
            m_Wrapper.m_Jugador1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movimiento.started += instance.OnMovimiento;
                @Movimiento.performed += instance.OnMovimiento;
                @Movimiento.canceled += instance.OnMovimiento;
                @Disparo.started += instance.OnDisparo;
                @Disparo.performed += instance.OnDisparo;
                @Disparo.canceled += instance.OnDisparo;
            }
        }
    }
    public Jugador1Actions @Jugador1 => new Jugador1Actions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Menupausa;
    private readonly InputAction m_Menu_NavegacionMenu;
    public struct MenuActions
    {
        private @InputMaster m_Wrapper;
        public MenuActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Menupausa => m_Wrapper.m_Menu_Menupausa;
        public InputAction @NavegacionMenu => m_Wrapper.m_Menu_NavegacionMenu;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Menupausa.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenupausa;
                @Menupausa.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenupausa;
                @Menupausa.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenupausa;
                @NavegacionMenu.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnNavegacionMenu;
                @NavegacionMenu.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnNavegacionMenu;
                @NavegacionMenu.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnNavegacionMenu;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Menupausa.started += instance.OnMenupausa;
                @Menupausa.performed += instance.OnMenupausa;
                @Menupausa.canceled += instance.OnMenupausa;
                @NavegacionMenu.started += instance.OnNavegacionMenu;
                @NavegacionMenu.performed += instance.OnNavegacionMenu;
                @NavegacionMenu.canceled += instance.OnNavegacionMenu;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int m_TecladoyMouseSchemeIndex = -1;
    public InputControlScheme TecladoyMouseScheme
    {
        get
        {
            if (m_TecladoyMouseSchemeIndex == -1) m_TecladoyMouseSchemeIndex = asset.FindControlSchemeIndex("Teclado y Mouse");
            return asset.controlSchemes[m_TecladoyMouseSchemeIndex];
        }
    }
    public interface IJugador1Actions
    {
        void OnMovimiento(InputAction.CallbackContext context);
        void OnDisparo(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnMenupausa(InputAction.CallbackContext context);
        void OnNavegacionMenu(InputAction.CallbackContext context);
    }
}
