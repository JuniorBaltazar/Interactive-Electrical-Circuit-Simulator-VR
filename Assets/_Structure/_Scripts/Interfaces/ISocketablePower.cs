using Baltazar.Utilities;

namespace XRProject.EletricalCircuit
{
    public interface ISocketablePower
    {
        void OnSelectedPower(EventBool interactablePower);
        void OnExitedPower(EventBool interactablePower);
    }
}