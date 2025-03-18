using UnityEngine;
using System;
using UnityEngine.XR.Interaction.Toolkit;

namespace XRProject.EletricalCircuit
{
    [RequireComponent(typeof(XRSocketInteractor))]
    public sealed class SocketController : MonoBehaviour
    {
        public XRSocketInteractor xrSocketInteractor;

        public Action<IXRSelectInteractable> eventAddConnect;
        public Action<IXRSelectInteractable> eventRemoveConnect;

        private IXRSelectInteractable selectInteractable;

        public IXRSelectInteractable SelectInteractable => selectInteractable;
        public bool HasAttach => xrSocketInteractor.hasSelection;

        private void Awake()
        {
            xrSocketInteractor = GetComponent<XRSocketInteractor>();

            xrSocketInteractor.selectEntered.AddListener(Addconnect);
            xrSocketInteractor.selectExited.AddListener(Removeconnect);
        }

        private void Addconnect(SelectEnterEventArgs selectEnterEvent)
        {
            Debug.Log($"add interactable", this);
            selectInteractable = selectEnterEvent.interactableObject;
            eventAddConnect?.Invoke(selectInteractable);
        }

        private void Removeconnect(SelectExitEventArgs selectExitEvent)
        {
            Debug.Log($"remove interactable", this);
            eventRemoveConnect?.Invoke(selectInteractable);
            selectInteractable = null;
        }
    }
}