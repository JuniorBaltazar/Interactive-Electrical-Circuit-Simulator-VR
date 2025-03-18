using UnityEngine;

namespace Baltazar.Utilities
{
    public class LookAt : MonoBehaviour
    {
        [SerializeField] private Transform _target;

        /// <summary>
        /// Quanto maior o valor do intervalo, maior a performance
        /// </summary>
        private int _interval = 3;

        public Transform Target => _target;

        private void Update()
        {
            Look();
        }

        private void Look()
        {
            if (Time.frameCount % _interval == 0 && _target != null)
            {
                transform.rotation = Quaternion.LookRotation(transform.position - _target.transform.position);
            }
        }

        public void SetTarget(Transform value)
        {
            _target = value;
        }
    }
}