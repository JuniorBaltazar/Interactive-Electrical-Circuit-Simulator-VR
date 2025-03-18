using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

namespace Baltazar.Utilities
{
    public sealed class InputActionEvent : MonoBehaviour
    {
        [SerializeField] private InputActionReference _spawnInputActionReference;

        [SerializeField] private UnityEvent _inputEvent;

        private void OnEnable()
        {
            _spawnInputActionReference.action.performed += OnInputEvent;
        }

        private void OnDisable()
        {
            _spawnInputActionReference.action.performed -= OnInputEvent;
        }

        private void OnInputEvent(CallbackContext callbackContext)
        {
            _inputEvent?.Invoke();
        }
    }
}