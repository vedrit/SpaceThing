// GENERATED AUTOMATICALLY FROM 'Assets/InputMaster.inputactions'

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
            ""name"": ""Admiral"",
            ""id"": ""e316f5aa-12b4-4e35-969a-e5f7c46bf0ec"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""78f6ba23-281d-4031-a0ab-1b80d7c305b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""8ae9bc0b-43ff-4ab1-aa0c-ff225ac382b5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""c48d1465-49a5-4f79-aec3-8a5583784ffa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraMove"",
                    ""type"": ""Button"",
                    ""id"": ""eb7a3a2a-1ce6-41f9-9311-93805ed72e7f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""6748c04d-e0c1-449f-8f46-48d7e497d8d6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6fc4b86b-1afd-400f-abc9-b40051a58d09"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""0da47a3d-d017-4caf-beda-9f276d10befd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6baa33b4-a262-45b5-a43b-f35d1c537966"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""02b7854f-348b-4a71-906f-468bfa9addd0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""404de561-59e1-44d6-8c53-61bdda643139"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""84d75219-e0b6-4cae-a197-532e141c824a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0a9c0059-59c0-4fd1-adfe-9d332e6c436d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9bddec4-7662-47b6-83e6-972bef4ffb06"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68eb29fd-aa46-401e-897f-b0d4cb39af6c"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Flight"",
            ""id"": ""70fcce7a-6cf1-4caa-8153-a40f330209ce"",
            ""actions"": [
                {
                    ""name"": ""Surge"",
                    ""type"": ""PassThrough"",
                    ""id"": ""00d72254-97a2-4897-9db3-35b7ad20db9b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sway"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6e6240a4-1bd0-4ec9-8547-60ea9f5901cb"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Heave"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f3f6d942-4c2b-449f-98ab-f1e6f973d5b5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""1dd55ad4-0cda-41c6-91f3-b7f3b1ab64e1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1792cdb4-cb86-4cb7-9b99-0fd48db0fe64"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseLook"",
                    ""type"": ""Button"",
                    ""id"": ""4a1994d4-7d05-43aa-87f6-919e48a8c16f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""9898e058-e13b-4805-a1af-6c9d9a7b0d64"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Roll"",
                    ""id"": ""5cc46400-d0b2-4521-8de2-4adf238a4f31"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""015149f2-42fc-4f44-a306-936a570e4480"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""eef02d7c-120e-4ec6-a23f-86e5f47ee9f1"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""561d5eea-68ce-48bd-b016-b60638047aab"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""MouseLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87967e77-8f18-41d1-956a-43f7c9f4a62b"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""62b39e4b-55e1-4c69-9d2d-360bd524abaf"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Surge"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""16145a58-1c8a-49f5-b001-9978c86b4491"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Surge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ad50d446-75ce-44f4-a464-98d9fb8c767c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Surge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""429fe4a1-aebf-4af7-bf36-539b7432bbbd"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Sway"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ab6f54ab-5bf6-403d-9768-24ce4f99cb5e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Sway"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""468876f7-2b30-4d5d-b31c-40730dd02461"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Sway"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""9e9321cc-664e-4989-90d3-d32388911e0c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Heave"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""98d45713-252a-4ca6-bcc0-c3829d9235ee"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Heave"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""64d2c178-e7a9-4948-bdd4-f615e0f77eb9"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Heave"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d78a68c1-d2d4-4b1c-a9aa-489489971e06"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""bc5dd743-dc86-410d-9b50-cf9eaa65c28e"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""a4989ffa-eea1-47cf-b290-6a02129564ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""05a4af95-fbc3-4663-a155-cd9ee59bdc97"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""RTS"",
            ""id"": ""a1b2d891-11f0-4301-8391-f44d70225b2a"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""27c20ea1-a956-4f20-ac9f-ef59a46c9b94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""695fcdac-c024-4290-b206-d20a33d0d210"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
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
        // Admiral
        m_Admiral = asset.FindActionMap("Admiral", throwIfNotFound: true);
        m_Admiral_Interact = m_Admiral.FindAction("Interact", throwIfNotFound: true);
        m_Admiral_Movement = m_Admiral.FindAction("Movement", throwIfNotFound: true);
        m_Admiral_Look = m_Admiral.FindAction("Look", throwIfNotFound: true);
        m_Admiral_CameraMove = m_Admiral.FindAction("CameraMove", throwIfNotFound: true);
        m_Admiral_MousePosition = m_Admiral.FindAction("MousePosition", throwIfNotFound: true);
        // Flight
        m_Flight = asset.FindActionMap("Flight", throwIfNotFound: true);
        m_Flight_Surge = m_Flight.FindAction("Surge", throwIfNotFound: true);
        m_Flight_Sway = m_Flight.FindAction("Sway", throwIfNotFound: true);
        m_Flight_Heave = m_Flight.FindAction("Heave", throwIfNotFound: true);
        m_Flight_Look = m_Flight.FindAction("Look", throwIfNotFound: true);
        m_Flight_Rotation = m_Flight.FindAction("Rotation", throwIfNotFound: true);
        m_Flight_MouseLook = m_Flight.FindAction("MouseLook", throwIfNotFound: true);
        m_Flight_Exit = m_Flight.FindAction("Exit", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Newaction = m_UI.FindAction("New action", throwIfNotFound: true);
        // RTS
        m_RTS = asset.FindActionMap("RTS", throwIfNotFound: true);
        m_RTS_Newaction = m_RTS.FindAction("New action", throwIfNotFound: true);
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

    // Admiral
    private readonly InputActionMap m_Admiral;
    private IAdmiralActions m_AdmiralActionsCallbackInterface;
    private readonly InputAction m_Admiral_Interact;
    private readonly InputAction m_Admiral_Movement;
    private readonly InputAction m_Admiral_Look;
    private readonly InputAction m_Admiral_CameraMove;
    private readonly InputAction m_Admiral_MousePosition;
    public struct AdmiralActions
    {
        private @InputMaster m_Wrapper;
        public AdmiralActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Admiral_Interact;
        public InputAction @Movement => m_Wrapper.m_Admiral_Movement;
        public InputAction @Look => m_Wrapper.m_Admiral_Look;
        public InputAction @CameraMove => m_Wrapper.m_Admiral_CameraMove;
        public InputAction @MousePosition => m_Wrapper.m_Admiral_MousePosition;
        public InputActionMap Get() { return m_Wrapper.m_Admiral; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AdmiralActions set) { return set.Get(); }
        public void SetCallbacks(IAdmiralActions instance)
        {
            if (m_Wrapper.m_AdmiralActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_AdmiralActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_AdmiralActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_AdmiralActionsCallbackInterface.OnInteract;
                @Movement.started -= m_Wrapper.m_AdmiralActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_AdmiralActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_AdmiralActionsCallbackInterface.OnMovement;
                @Look.started -= m_Wrapper.m_AdmiralActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_AdmiralActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_AdmiralActionsCallbackInterface.OnLook;
                @CameraMove.started -= m_Wrapper.m_AdmiralActionsCallbackInterface.OnCameraMove;
                @CameraMove.performed -= m_Wrapper.m_AdmiralActionsCallbackInterface.OnCameraMove;
                @CameraMove.canceled -= m_Wrapper.m_AdmiralActionsCallbackInterface.OnCameraMove;
                @MousePosition.started -= m_Wrapper.m_AdmiralActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_AdmiralActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_AdmiralActionsCallbackInterface.OnMousePosition;
            }
            m_Wrapper.m_AdmiralActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @CameraMove.started += instance.OnCameraMove;
                @CameraMove.performed += instance.OnCameraMove;
                @CameraMove.canceled += instance.OnCameraMove;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
            }
        }
    }
    public AdmiralActions @Admiral => new AdmiralActions(this);

    // Flight
    private readonly InputActionMap m_Flight;
    private IFlightActions m_FlightActionsCallbackInterface;
    private readonly InputAction m_Flight_Surge;
    private readonly InputAction m_Flight_Sway;
    private readonly InputAction m_Flight_Heave;
    private readonly InputAction m_Flight_Look;
    private readonly InputAction m_Flight_Rotation;
    private readonly InputAction m_Flight_MouseLook;
    private readonly InputAction m_Flight_Exit;
    public struct FlightActions
    {
        private @InputMaster m_Wrapper;
        public FlightActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Surge => m_Wrapper.m_Flight_Surge;
        public InputAction @Sway => m_Wrapper.m_Flight_Sway;
        public InputAction @Heave => m_Wrapper.m_Flight_Heave;
        public InputAction @Look => m_Wrapper.m_Flight_Look;
        public InputAction @Rotation => m_Wrapper.m_Flight_Rotation;
        public InputAction @MouseLook => m_Wrapper.m_Flight_MouseLook;
        public InputAction @Exit => m_Wrapper.m_Flight_Exit;
        public InputActionMap Get() { return m_Wrapper.m_Flight; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FlightActions set) { return set.Get(); }
        public void SetCallbacks(IFlightActions instance)
        {
            if (m_Wrapper.m_FlightActionsCallbackInterface != null)
            {
                @Surge.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnSurge;
                @Surge.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnSurge;
                @Surge.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnSurge;
                @Sway.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnSway;
                @Sway.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnSway;
                @Sway.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnSway;
                @Heave.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnHeave;
                @Heave.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnHeave;
                @Heave.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnHeave;
                @Look.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnLook;
                @Rotation.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnRotation;
                @MouseLook.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnMouseLook;
                @MouseLook.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnMouseLook;
                @MouseLook.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnMouseLook;
                @Exit.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnExit;
            }
            m_Wrapper.m_FlightActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Surge.started += instance.OnSurge;
                @Surge.performed += instance.OnSurge;
                @Surge.canceled += instance.OnSurge;
                @Sway.started += instance.OnSway;
                @Sway.performed += instance.OnSway;
                @Sway.canceled += instance.OnSway;
                @Heave.started += instance.OnHeave;
                @Heave.performed += instance.OnHeave;
                @Heave.canceled += instance.OnHeave;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @MouseLook.started += instance.OnMouseLook;
                @MouseLook.performed += instance.OnMouseLook;
                @MouseLook.canceled += instance.OnMouseLook;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
            }
        }
    }
    public FlightActions @Flight => new FlightActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Newaction;
    public struct UIActions
    {
        private @InputMaster m_Wrapper;
        public UIActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_UI_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // RTS
    private readonly InputActionMap m_RTS;
    private IRTSActions m_RTSActionsCallbackInterface;
    private readonly InputAction m_RTS_Newaction;
    public struct RTSActions
    {
        private @InputMaster m_Wrapper;
        public RTSActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_RTS_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_RTS; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RTSActions set) { return set.Get(); }
        public void SetCallbacks(IRTSActions instance)
        {
            if (m_Wrapper.m_RTSActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_RTSActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_RTSActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_RTSActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_RTSActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public RTSActions @RTS => new RTSActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    public interface IAdmiralActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnCameraMove(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
    }
    public interface IFlightActions
    {
        void OnSurge(InputAction.CallbackContext context);
        void OnSway(InputAction.CallbackContext context);
        void OnHeave(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnMouseLook(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IRTSActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
