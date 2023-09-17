//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.1
//     from Assets/Input/Ref/Ref_Input.inputactions
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

public partial class @Ref_Input: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Ref_Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Ref_Input"",
    ""maps"": [
        {
            ""name"": ""DefaultMap"",
            ""id"": ""ee049613-5439-4ee4-a5ec-48b9e42b3d66"",
            ""actions"": [
                {
                    ""name"": ""MovePosition"",
                    ""type"": ""Button"",
                    ""id"": ""b10ff0cc-fb4f-4676-96c4-c679b3d784d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4ae24b34-7c16-49af-bc6a-924ac2ab95b3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // DefaultMap
        m_DefaultMap = asset.FindActionMap("DefaultMap", throwIfNotFound: true);
        m_DefaultMap_MovePosition = m_DefaultMap.FindAction("MovePosition", throwIfNotFound: true);
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

    // DefaultMap
    private readonly InputActionMap m_DefaultMap;
    private List<IDefaultMapActions> m_DefaultMapActionsCallbackInterfaces = new List<IDefaultMapActions>();
    private readonly InputAction m_DefaultMap_MovePosition;
    public struct DefaultMapActions
    {
        private @Ref_Input m_Wrapper;
        public DefaultMapActions(@Ref_Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovePosition => m_Wrapper.m_DefaultMap_MovePosition;
        public InputActionMap Get() { return m_Wrapper.m_DefaultMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultMapActions set) { return set.Get(); }
        public void AddCallbacks(IDefaultMapActions instance)
        {
            if (instance == null || m_Wrapper.m_DefaultMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DefaultMapActionsCallbackInterfaces.Add(instance);
            @MovePosition.started += instance.OnMovePosition;
            @MovePosition.performed += instance.OnMovePosition;
            @MovePosition.canceled += instance.OnMovePosition;
        }

        private void UnregisterCallbacks(IDefaultMapActions instance)
        {
            @MovePosition.started -= instance.OnMovePosition;
            @MovePosition.performed -= instance.OnMovePosition;
            @MovePosition.canceled -= instance.OnMovePosition;
        }

        public void RemoveCallbacks(IDefaultMapActions instance)
        {
            if (m_Wrapper.m_DefaultMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDefaultMapActions instance)
        {
            foreach (var item in m_Wrapper.m_DefaultMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DefaultMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DefaultMapActions @DefaultMap => new DefaultMapActions(this);
    public interface IDefaultMapActions
    {
        void OnMovePosition(InputAction.CallbackContext context);
    }
}