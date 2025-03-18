using Baltazar.Utilities;
using UnityEngine;

namespace XRProject.EletricalCircuit
{
    [RequireComponent(typeof(SocketPowerController))]
    public sealed class WireController : MonoBehaviour, ISocketablePower
    {
        private EventBool _havePower;

        private SocketPowerController _socketPowerController;

        private void Awake()
        {            
            _havePower = GetComponent<EventBool>();
            _socketPowerController = GetComponent<SocketPowerController>();
        }

        public void HandlerUpdateInteractablePower()
        {
            EventBool interactablePower = _socketPowerController.InteractablePower;

            if (interactablePower != null)
            {
                interactablePower.SetEnable(_havePower.EnableBool);
            }
        }

        void ISocketablePower.OnSelectedPower(EventBool interactablePower)
        {
            interactablePower.SetEnable(_havePower.EnableBool);
        }

        void ISocketablePower.OnExitedPower(EventBool interactablePower)
        {
            interactablePower.SetEnable(false);
        }
    }
}