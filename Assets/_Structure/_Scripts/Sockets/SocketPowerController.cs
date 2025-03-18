using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Baltazar.Utilities;

namespace XRProject.EletricalCircuit
{
    public sealed class SocketPowerController : MonoBehaviour, ISocketableSelectExit
    {
        private EventBool _interactablePower;

        private ISocketablePower _socketablePower;

        public EventBool InteractablePower => _interactablePower;

        private void Awake()
        {
            _socketablePower = GetComponent<ISocketablePower>();
        }

        public void OnSelectedConnect(IXRSelectInteractable interactable)
        {
            EventBool interactablePower = interactable.transform.GetComponent<EventBool>();

            if (interactablePower)
            {
                _interactablePower = interactablePower;

                _socketablePower.OnSelectedPower(_interactablePower);
            }
        }

        public void OnExitedConnect(IXRSelectInteractable interactable)
        {
            if (_interactablePower == null)
            {
                return;
            }

            _socketablePower.OnExitedPower(_interactablePower);
            _interactablePower = null;
        }
    }
}