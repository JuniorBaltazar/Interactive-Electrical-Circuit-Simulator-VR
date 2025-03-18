using UnityEngine;
using Baltazar.Utilities;

namespace XRProject.EletricalCircuit
{
    [RequireComponent(typeof(SocketPowerController))]
    public sealed class PowerSourceController : MonoBehaviour, ISocketablePower
    {
        void ISocketablePower.OnSelectedPower(EventBool interactablePower)
        {
            interactablePower.SetEnable(true);
        }

        void ISocketablePower.OnExitedPower(EventBool interactablePower)
        {
            interactablePower.SetEnable(false);
        }
    }
}