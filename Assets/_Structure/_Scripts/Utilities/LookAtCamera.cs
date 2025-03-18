using UnityEngine;

namespace Baltazar.Utilities
{
    [RequireComponent(typeof(LookAt))]
    public class LookAtCamera : MonoBehaviour
    {
        private LookAt _lookAt;

        private void Awake()
        {
            _lookAt = GetComponent<LookAt>();
        }

        private void OnEnable()
        {
            if (_lookAt.Target != null)
            {
                return;
            }

            _lookAt.SetTarget(Camera.main.transform);
        }
    }
}