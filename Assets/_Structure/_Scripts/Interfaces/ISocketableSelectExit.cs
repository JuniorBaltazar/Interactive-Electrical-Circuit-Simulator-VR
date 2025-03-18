using UnityEngine.XR.Interaction.Toolkit;

namespace XRProject.EletricalCircuit
{
    public interface ISocketableSelectExit
    {
        void OnSelectedConnect(IXRSelectInteractable interactable);
        void OnExitedConnect(IXRSelectInteractable interactable);
    }
}