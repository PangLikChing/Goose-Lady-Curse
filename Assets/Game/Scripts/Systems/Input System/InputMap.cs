//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Game/Scripts/Systems/Input System/InputMap.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputMap : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMap"",
    ""maps"": [
        {
            ""name"": ""CharacterControls"",
            ""id"": ""e55c5bde-0eda-4408-8f85-f15cde7656ae"",
            ""actions"": [
                {
                    ""name"": ""Movements"",
                    ""type"": ""Button"",
                    ""id"": ""199c4cb1-e463-4272-bd15-b3c2a5041a40"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""a853cac7-4b32-43ba-bbbf-4d712c9d06be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pickup"",
                    ""type"": ""Button"",
                    ""id"": ""b312c2f0-3519-47cc-a6ba-0b94cbaf0b83"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""364a2d9e-e640-4399-b576-f9af6893d587"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Zoom Camera"",
                    ""type"": ""Value"",
                    ""id"": ""903bb619-39f0-48fc-a3ae-d4d2cf839c66"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bf98d498-0caa-4f88-9f1b-60ea5209919b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25c07e52-12d4-485a-9407-63d0675f689e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""829299c5-9634-485d-a67e-b9d053be1bf2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee98d194-6a0a-4859-b9ca-e358023ed41f"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e554808-3215-4be4-ba68-46bc3b3da480"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Zoom Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GameplayMenus"",
            ""id"": ""ea0b755a-bbf3-44d5-b638-bb2ffb120b5d"",
            ""actions"": [
                {
                    ""name"": ""Close All Menus"",
                    ""type"": ""Button"",
                    ""id"": ""3c9ff53b-abff-474f-8978-ab19d008d999"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Open Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""11f909ad-af5f-4289-9123-e3bf2a57c69e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Open Character Panel"",
                    ""type"": ""Button"",
                    ""id"": ""dd29ca27-dbbd-4e28-9a9b-a74178c24f79"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Open Crafting Menu"",
                    ""type"": ""Button"",
                    ""id"": ""30cf5245-9f1a-4624-8d51-1f70b6c38558"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Open Build Menu"",
                    ""type"": ""Button"",
                    ""id"": ""0054a390-db32-4213-b691-10526f1a97bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Open Help Menu"",
                    ""type"": ""Button"",
                    ""id"": ""3078781a-9c8f-49f8-9379-252ec39363bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Open Pause Menu"",
                    ""type"": ""Button"",
                    ""id"": ""dcf37114-5fe8-4a7d-ad74-0e56c8f9839d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Open Note Book"",
                    ""type"": ""Button"",
                    ""id"": ""a3b59eef-8dae-4b50-b85f-43b1306f3ecc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""29ebcdec-880c-45f0-962a-ed65ce685971"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close All Menus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d401d6b-b35b-4279-b455-0aeab7029cf6"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Open Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""262e0a90-8472-4fbb-a9a0-15d213f255ca"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open Character Panel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc43228a-7bed-452e-89d7-27c5d4b5f139"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open Crafting Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f537512f-fa8e-410b-8acc-ed5bdc0d6ab6"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open Build Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc767295-f58d-41c3-89ad-ea10ca690ea1"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open Help Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a296228-f82d-4278-8584-7bb20979e8ca"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open Pause Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9319185-b467-4255-b2f0-76bd34789829"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open Note Book"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""SystemMenus"",
            ""id"": ""96b8b93d-0c59-407e-b167-af9cad8e6792"",
            ""actions"": [
                {
                    ""name"": ""Close Pause Menu"",
                    ""type"": ""Button"",
                    ""id"": ""10ed0b81-2a2f-4527-aca3-5c159b37a31a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""15c23046-80c6-4a91-807c-84379db2e7e3"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Close Pause Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Dialogues"",
            ""id"": ""d4484669-ab58-4396-9000-f6ebb7a206cb"",
            ""actions"": [
                {
                    ""name"": ""Skip Dialog"",
                    ""type"": ""Button"",
                    ""id"": ""6bebee07-61d2-4781-862e-bfbce6a3bef6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""42f3015e-f612-4b15-b89d-560b5992c28a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip Dialog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse and Keyboard"",
            ""bindingGroup"": ""Mouse and Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // CharacterControls
        m_CharacterControls = asset.FindActionMap("CharacterControls", throwIfNotFound: true);
        m_CharacterControls_Movements = m_CharacterControls.FindAction("Movements", throwIfNotFound: true);
        m_CharacterControls_Attack = m_CharacterControls.FindAction("Attack", throwIfNotFound: true);
        m_CharacterControls_Pickup = m_CharacterControls.FindAction("Pickup", throwIfNotFound: true);
        m_CharacterControls_Interact = m_CharacterControls.FindAction("Interact", throwIfNotFound: true);
        m_CharacterControls_ZoomCamera = m_CharacterControls.FindAction("Zoom Camera", throwIfNotFound: true);
        // GameplayMenus
        m_GameplayMenus = asset.FindActionMap("GameplayMenus", throwIfNotFound: true);
        m_GameplayMenus_CloseAllMenus = m_GameplayMenus.FindAction("Close All Menus", throwIfNotFound: true);
        m_GameplayMenus_OpenInventory = m_GameplayMenus.FindAction("Open Inventory", throwIfNotFound: true);
        m_GameplayMenus_OpenCharacterPanel = m_GameplayMenus.FindAction("Open Character Panel", throwIfNotFound: true);
        m_GameplayMenus_OpenCraftingMenu = m_GameplayMenus.FindAction("Open Crafting Menu", throwIfNotFound: true);
        m_GameplayMenus_OpenBuildMenu = m_GameplayMenus.FindAction("Open Build Menu", throwIfNotFound: true);
        m_GameplayMenus_OpenHelpMenu = m_GameplayMenus.FindAction("Open Help Menu", throwIfNotFound: true);
        m_GameplayMenus_OpenPauseMenu = m_GameplayMenus.FindAction("Open Pause Menu", throwIfNotFound: true);
        m_GameplayMenus_OpenNoteBook = m_GameplayMenus.FindAction("Open Note Book", throwIfNotFound: true);
        // SystemMenus
        m_SystemMenus = asset.FindActionMap("SystemMenus", throwIfNotFound: true);
        m_SystemMenus_ClosePauseMenu = m_SystemMenus.FindAction("Close Pause Menu", throwIfNotFound: true);
        // Dialogues
        m_Dialogues = asset.FindActionMap("Dialogues", throwIfNotFound: true);
        m_Dialogues_SkipDialog = m_Dialogues.FindAction("Skip Dialog", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // CharacterControls
    private readonly InputActionMap m_CharacterControls;
    private ICharacterControlsActions m_CharacterControlsActionsCallbackInterface;
    private readonly InputAction m_CharacterControls_Movements;
    private readonly InputAction m_CharacterControls_Attack;
    private readonly InputAction m_CharacterControls_Pickup;
    private readonly InputAction m_CharacterControls_Interact;
    private readonly InputAction m_CharacterControls_ZoomCamera;
    public struct CharacterControlsActions
    {
        private @InputMap m_Wrapper;
        public CharacterControlsActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movements => m_Wrapper.m_CharacterControls_Movements;
        public InputAction @Attack => m_Wrapper.m_CharacterControls_Attack;
        public InputAction @Pickup => m_Wrapper.m_CharacterControls_Pickup;
        public InputAction @Interact => m_Wrapper.m_CharacterControls_Interact;
        public InputAction @ZoomCamera => m_Wrapper.m_CharacterControls_ZoomCamera;
        public InputActionMap Get() { return m_Wrapper.m_CharacterControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterControlsActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterControlsActions instance)
        {
            if (m_Wrapper.m_CharacterControlsActionsCallbackInterface != null)
            {
                @Movements.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnMovements;
                @Movements.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnMovements;
                @Movements.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnMovements;
                @Attack.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnAttack;
                @Pickup.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnPickup;
                @Pickup.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnPickup;
                @Pickup.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnPickup;
                @Interact.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnInteract;
                @ZoomCamera.started -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnZoomCamera;
                @ZoomCamera.performed -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnZoomCamera;
                @ZoomCamera.canceled -= m_Wrapper.m_CharacterControlsActionsCallbackInterface.OnZoomCamera;
            }
            m_Wrapper.m_CharacterControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movements.started += instance.OnMovements;
                @Movements.performed += instance.OnMovements;
                @Movements.canceled += instance.OnMovements;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Pickup.started += instance.OnPickup;
                @Pickup.performed += instance.OnPickup;
                @Pickup.canceled += instance.OnPickup;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @ZoomCamera.started += instance.OnZoomCamera;
                @ZoomCamera.performed += instance.OnZoomCamera;
                @ZoomCamera.canceled += instance.OnZoomCamera;
            }
        }
    }
    public CharacterControlsActions @CharacterControls => new CharacterControlsActions(this);

    // GameplayMenus
    private readonly InputActionMap m_GameplayMenus;
    private IGameplayMenusActions m_GameplayMenusActionsCallbackInterface;
    private readonly InputAction m_GameplayMenus_CloseAllMenus;
    private readonly InputAction m_GameplayMenus_OpenInventory;
    private readonly InputAction m_GameplayMenus_OpenCharacterPanel;
    private readonly InputAction m_GameplayMenus_OpenCraftingMenu;
    private readonly InputAction m_GameplayMenus_OpenBuildMenu;
    private readonly InputAction m_GameplayMenus_OpenHelpMenu;
    private readonly InputAction m_GameplayMenus_OpenPauseMenu;
    private readonly InputAction m_GameplayMenus_OpenNoteBook;
    public struct GameplayMenusActions
    {
        private @InputMap m_Wrapper;
        public GameplayMenusActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @CloseAllMenus => m_Wrapper.m_GameplayMenus_CloseAllMenus;
        public InputAction @OpenInventory => m_Wrapper.m_GameplayMenus_OpenInventory;
        public InputAction @OpenCharacterPanel => m_Wrapper.m_GameplayMenus_OpenCharacterPanel;
        public InputAction @OpenCraftingMenu => m_Wrapper.m_GameplayMenus_OpenCraftingMenu;
        public InputAction @OpenBuildMenu => m_Wrapper.m_GameplayMenus_OpenBuildMenu;
        public InputAction @OpenHelpMenu => m_Wrapper.m_GameplayMenus_OpenHelpMenu;
        public InputAction @OpenPauseMenu => m_Wrapper.m_GameplayMenus_OpenPauseMenu;
        public InputAction @OpenNoteBook => m_Wrapper.m_GameplayMenus_OpenNoteBook;
        public InputActionMap Get() { return m_Wrapper.m_GameplayMenus; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayMenusActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayMenusActions instance)
        {
            if (m_Wrapper.m_GameplayMenusActionsCallbackInterface != null)
            {
                @CloseAllMenus.started -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnCloseAllMenus;
                @CloseAllMenus.performed -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnCloseAllMenus;
                @CloseAllMenus.canceled -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnCloseAllMenus;
                @OpenInventory.started -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenInventory;
                @OpenInventory.performed -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenInventory;
                @OpenInventory.canceled -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenInventory;
                @OpenCharacterPanel.started -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenCharacterPanel;
                @OpenCharacterPanel.performed -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenCharacterPanel;
                @OpenCharacterPanel.canceled -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenCharacterPanel;
                @OpenCraftingMenu.started -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenCraftingMenu;
                @OpenCraftingMenu.performed -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenCraftingMenu;
                @OpenCraftingMenu.canceled -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenCraftingMenu;
                @OpenBuildMenu.started -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenBuildMenu;
                @OpenBuildMenu.performed -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenBuildMenu;
                @OpenBuildMenu.canceled -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenBuildMenu;
                @OpenHelpMenu.started -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenHelpMenu;
                @OpenHelpMenu.performed -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenHelpMenu;
                @OpenHelpMenu.canceled -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenHelpMenu;
                @OpenPauseMenu.started -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenPauseMenu;
                @OpenPauseMenu.performed -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenPauseMenu;
                @OpenPauseMenu.canceled -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenPauseMenu;
                @OpenNoteBook.started -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenNoteBook;
                @OpenNoteBook.performed -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenNoteBook;
                @OpenNoteBook.canceled -= m_Wrapper.m_GameplayMenusActionsCallbackInterface.OnOpenNoteBook;
            }
            m_Wrapper.m_GameplayMenusActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CloseAllMenus.started += instance.OnCloseAllMenus;
                @CloseAllMenus.performed += instance.OnCloseAllMenus;
                @CloseAllMenus.canceled += instance.OnCloseAllMenus;
                @OpenInventory.started += instance.OnOpenInventory;
                @OpenInventory.performed += instance.OnOpenInventory;
                @OpenInventory.canceled += instance.OnOpenInventory;
                @OpenCharacterPanel.started += instance.OnOpenCharacterPanel;
                @OpenCharacterPanel.performed += instance.OnOpenCharacterPanel;
                @OpenCharacterPanel.canceled += instance.OnOpenCharacterPanel;
                @OpenCraftingMenu.started += instance.OnOpenCraftingMenu;
                @OpenCraftingMenu.performed += instance.OnOpenCraftingMenu;
                @OpenCraftingMenu.canceled += instance.OnOpenCraftingMenu;
                @OpenBuildMenu.started += instance.OnOpenBuildMenu;
                @OpenBuildMenu.performed += instance.OnOpenBuildMenu;
                @OpenBuildMenu.canceled += instance.OnOpenBuildMenu;
                @OpenHelpMenu.started += instance.OnOpenHelpMenu;
                @OpenHelpMenu.performed += instance.OnOpenHelpMenu;
                @OpenHelpMenu.canceled += instance.OnOpenHelpMenu;
                @OpenPauseMenu.started += instance.OnOpenPauseMenu;
                @OpenPauseMenu.performed += instance.OnOpenPauseMenu;
                @OpenPauseMenu.canceled += instance.OnOpenPauseMenu;
                @OpenNoteBook.started += instance.OnOpenNoteBook;
                @OpenNoteBook.performed += instance.OnOpenNoteBook;
                @OpenNoteBook.canceled += instance.OnOpenNoteBook;
            }
        }
    }
    public GameplayMenusActions @GameplayMenus => new GameplayMenusActions(this);

    // SystemMenus
    private readonly InputActionMap m_SystemMenus;
    private ISystemMenusActions m_SystemMenusActionsCallbackInterface;
    private readonly InputAction m_SystemMenus_ClosePauseMenu;
    public struct SystemMenusActions
    {
        private @InputMap m_Wrapper;
        public SystemMenusActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @ClosePauseMenu => m_Wrapper.m_SystemMenus_ClosePauseMenu;
        public InputActionMap Get() { return m_Wrapper.m_SystemMenus; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SystemMenusActions set) { return set.Get(); }
        public void SetCallbacks(ISystemMenusActions instance)
        {
            if (m_Wrapper.m_SystemMenusActionsCallbackInterface != null)
            {
                @ClosePauseMenu.started -= m_Wrapper.m_SystemMenusActionsCallbackInterface.OnClosePauseMenu;
                @ClosePauseMenu.performed -= m_Wrapper.m_SystemMenusActionsCallbackInterface.OnClosePauseMenu;
                @ClosePauseMenu.canceled -= m_Wrapper.m_SystemMenusActionsCallbackInterface.OnClosePauseMenu;
            }
            m_Wrapper.m_SystemMenusActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ClosePauseMenu.started += instance.OnClosePauseMenu;
                @ClosePauseMenu.performed += instance.OnClosePauseMenu;
                @ClosePauseMenu.canceled += instance.OnClosePauseMenu;
            }
        }
    }
    public SystemMenusActions @SystemMenus => new SystemMenusActions(this);

    // Dialogues
    private readonly InputActionMap m_Dialogues;
    private IDialoguesActions m_DialoguesActionsCallbackInterface;
    private readonly InputAction m_Dialogues_SkipDialog;
    public struct DialoguesActions
    {
        private @InputMap m_Wrapper;
        public DialoguesActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @SkipDialog => m_Wrapper.m_Dialogues_SkipDialog;
        public InputActionMap Get() { return m_Wrapper.m_Dialogues; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DialoguesActions set) { return set.Get(); }
        public void SetCallbacks(IDialoguesActions instance)
        {
            if (m_Wrapper.m_DialoguesActionsCallbackInterface != null)
            {
                @SkipDialog.started -= m_Wrapper.m_DialoguesActionsCallbackInterface.OnSkipDialog;
                @SkipDialog.performed -= m_Wrapper.m_DialoguesActionsCallbackInterface.OnSkipDialog;
                @SkipDialog.canceled -= m_Wrapper.m_DialoguesActionsCallbackInterface.OnSkipDialog;
            }
            m_Wrapper.m_DialoguesActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SkipDialog.started += instance.OnSkipDialog;
                @SkipDialog.performed += instance.OnSkipDialog;
                @SkipDialog.canceled += instance.OnSkipDialog;
            }
        }
    }
    public DialoguesActions @Dialogues => new DialoguesActions(this);
    private int m_MouseandKeyboardSchemeIndex = -1;
    public InputControlScheme MouseandKeyboardScheme
    {
        get
        {
            if (m_MouseandKeyboardSchemeIndex == -1) m_MouseandKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse and Keyboard");
            return asset.controlSchemes[m_MouseandKeyboardSchemeIndex];
        }
    }
    public interface ICharacterControlsActions
    {
        void OnMovements(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnPickup(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnZoomCamera(InputAction.CallbackContext context);
    }
    public interface IGameplayMenusActions
    {
        void OnCloseAllMenus(InputAction.CallbackContext context);
        void OnOpenInventory(InputAction.CallbackContext context);
        void OnOpenCharacterPanel(InputAction.CallbackContext context);
        void OnOpenCraftingMenu(InputAction.CallbackContext context);
        void OnOpenBuildMenu(InputAction.CallbackContext context);
        void OnOpenHelpMenu(InputAction.CallbackContext context);
        void OnOpenPauseMenu(InputAction.CallbackContext context);
        void OnOpenNoteBook(InputAction.CallbackContext context);
    }
    public interface ISystemMenusActions
    {
        void OnClosePauseMenu(InputAction.CallbackContext context);
    }
    public interface IDialoguesActions
    {
        void OnSkipDialog(InputAction.CallbackContext context);
    }
}
