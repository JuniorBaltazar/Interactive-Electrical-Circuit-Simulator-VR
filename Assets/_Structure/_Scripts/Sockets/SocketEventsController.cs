using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;

namespace XRProject.EletricalCircuit
{
    [RequireComponent(typeof(SocketSystem))]
    public sealed class SocketEventsController : MonoBehaviour
    {
        [SerializeField] private UnityEvent _eventEnableAllConnects;
        [SerializeField] private UnityEvent _eventDisableAllConnects;

        private SocketSystem _socketSystem;

        public Action eventAddConnect;
        public Action eventRemoveConnect;

        public Action<bool> _eventAllConnects;

        private ISocketableSelectExit socketable;

        private void Awake()
        {
            _socketSystem = GetComponent<SocketSystem>();            

            ConfigureSocketable();
            OnAddSocketEvents();
        }


        public void SetAddConnectEvent(Action<IXRSelectInteractable> onAddConnect)
        {
            _socketSystem.eventAddConnect += onAddConnect.Invoke;
        }

        public void SetRemoveConnectEvent(Action<IXRSelectInteractable> onRemoveConnect)
        {
            _socketSystem.eventRemoveConnect += onRemoveConnect.Invoke;
        }

        public void SetAddConnectEvent(Action onAddConnect)
        {
            eventAddConnect += onAddConnect.Invoke;
        }

        public void SetRemoveConnectEvent(Action onRemoveConnect)
        {
            eventRemoveConnect += onRemoveConnect.Invoke;
        }
        private void ConfigureSocketable()
        {
            socketable = GetComponent<ISocketableSelectExit>();

            if (socketable == null)
            {
                return;
            }

            _socketSystem.eventAddConnect += socketable.OnSelectedConnect;
            _socketSystem.eventRemoveConnect += socketable.OnExitedConnect;
        }

        private void OnAddSocketEvents()
        {
            _socketSystem.eventAddConnect += OnCheckConnect;
            _socketSystem.eventRemoveConnect += OnCheckConnect;

            _socketSystem.eventAddConnect += OnAddConnect;
            _socketSystem.eventRemoveConnect += OnRemoveConnect;

            

            _eventAllConnects += OnEventAllEnable;
        }

        private void OnCheckConnect(IXRSelectInteractable interactable)
        {
            _socketSystem.GetHasAllAttach(OnSwitchOn, OnSwitchOff);

            void OnSwitchOn() => _eventAllConnects?.Invoke(true);
            void OnSwitchOff() => _eventAllConnects?.Invoke(false);
        }

        private void OnEventAllEnable(bool enable)
        {
            if (enable == true)
            {
                _eventEnableAllConnects?.Invoke();
                return;
            }

            _eventDisableAllConnects?.Invoke();
        }

        private void OnAddConnect(IXRSelectInteractable interactable)
        {
            eventAddConnect?.Invoke();
        }

        private void OnRemoveConnect(IXRSelectInteractable interactable)
        {
            eventRemoveConnect?.Invoke();
        }
    }
}