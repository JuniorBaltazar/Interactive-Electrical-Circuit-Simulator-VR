using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace XRProject.EletricalCircuit
{
    public sealed class SocketSystem : MonoBehaviour
    {
        [SerializeField] private List<SocketController> xrSocketInteractors = new List<SocketController>();

        public Action<IXRSelectInteractable> eventAddConnect;
        public Action<IXRSelectInteractable> eventRemoveConnect;

        public byte SocketCount => (byte)XRSocketInteractors.Count;
        public List<SocketController> XRSocketInteractors => xrSocketInteractors;

        private List<IXRSelectInteractable> _selectInteractables = new List<IXRSelectInteractable>();

        private void Awake()
        {
            OnAddSocketEvents();
        }

        public List<IXRSelectInteractable> GetAllInteractables()
        {
            _selectInteractables.Clear();

            foreach (SocketController socketController in xrSocketInteractors)
            {
                if (IsDisableSocketController(socketController))
                {
                    continue;
                }

                IXRSelectInteractable selectInteractable = socketController.SelectInteractable;

                if (selectInteractable == null)
                {
                    continue;
                }

                _selectInteractables.Add(selectInteractable);
            }

            return _selectInteractables;
        }

        public bool GetHasAllAttach(Action onSuccess = null, Action onError = null)
        {
            foreach (SocketController socketController in xrSocketInteractors)
            {
                if (IsDisableSocketController(socketController))
                {
                    continue;
                }

                if (socketController.HasAttach == false)
                {
                    onError?.Invoke();
                    return false;
                }
            }

            onSuccess?.Invoke();
            return true;
        }

        private static bool IsDisableSocketController(SocketController socketController)
        {
            return socketController.isActiveAndEnabled == false;
        }

        private void OnAddSocketEvents()
        {
            foreach (SocketController socketController in xrSocketInteractors)
            {
                if (IsDisableSocketController(socketController))
                {
                    continue;
                }

                socketController.eventAddConnect += OnAddConnect;
                socketController.eventRemoveConnect += OnRemoveConnect;
            }
        }

        private void OnAddConnect(IXRSelectInteractable interactable)
        {
            Debug.Log($"add connect in socket", this);

            eventAddConnect?.Invoke(interactable);
        }

        private void OnRemoveConnect(IXRSelectInteractable interactable)
        {
            eventRemoveConnect?.Invoke(interactable);
        }
    }
}