using System;
using UnityEngine;
using UnityEngine.Events;

namespace Baltazar.Utilities
{
    public sealed class EventBool : MonoBehaviour
    {
        [SerializeField] private bool _enableBool = false;

        [SerializeField] private UnityEvent _eventActive;
        [SerializeField] private UnityEvent _eventDesactive;

        public bool EnableBool => _enableBool;

        public void SetEnable(bool enable, Action onSucess = null, Action onError = null)
        {
            if (gameObject.activeInHierarchy == false || _enableBool == enable)
            {
                return;
            }

            _enableBool = enable;
            SetUpdateEnable(onSucess, onError);
        }

        public void SetUpdateEnable(Action onSucess = null, Action onError = null)
        {
            if (gameObject.activeInHierarchy == false)
            {
                return;
            }

            bool isActive = _enableBool == true;

            if (isActive == true && onSucess != null)
            {
                _eventActive.AddListener(OnSucess);
            }

            if (isActive == false && onError != null)
            {
                _eventDesactive.AddListener(OnError);
            }

            UnityEvent eventEnable = isActive ? _eventActive : _eventDesactive;

            eventEnable?.Invoke();

            void OnSucess()
            {
                onSucess?.Invoke();

                _eventActive.RemoveListener(OnSucess);
            }

            void OnError()
            {
                onError?.Invoke();

                _eventDesactive.RemoveListener(OnError);
            }
        }

        public void HandlerSwitchEnable()
        {
            _enableBool = !_enableBool;
            SetUpdateEnable();
        }

        public void HandlerUpdateEnable()
        {
            SetUpdateEnable();
        }
    }
}