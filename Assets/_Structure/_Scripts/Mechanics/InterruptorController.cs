using UnityEngine;
using Baltazar.Utilities;

namespace XRProject.EletricalCircuit
{
    [RequireComponent(typeof(SocketPowerController))]
    public sealed class InterruptorController : MonoBehaviour, ISocketablePower
    {
        [SerializeField] private EventBool _havePower;
        [SerializeField] private EventBool _enable;

        private SocketPowerController _socketPowerController;

        private void Awake()
        {
            _socketPowerController = GetComponent<SocketPowerController>();
        }

        public void HandlerUpdateInterruptor()
        {
            UpdatePower();
        }

        private void UpdatePower()
        {
            EventBool interactablePower = _socketPowerController.InteractablePower;

            if (interactablePower == null)
            {
                return;
            }

            bool enablePower = _havePower.EnableBool == true && _enable.EnableBool == true;
            interactablePower.SetEnable(enablePower);
        }

        void ISocketablePower.OnSelectedPower(EventBool interactablePower)
        {
            interactablePower.SetEnable(true);
            HandlerUpdateInterruptor();
        }

        void ISocketablePower.OnExitedPower(EventBool interactablePower)
        {
            interactablePower.SetEnable(false);
        }
    }
}