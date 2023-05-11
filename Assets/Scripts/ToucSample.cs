using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ToucSample : MonoBehaviour
{
    [SerializeField] private XRBaseControllerInteractor _interactor;
    private void OnEnable()
    {
        _interactor.hoverEntered.AddListener(DebugPrint);
        _interactor.hoverExited.AddListener(DebugPrint);
        _interactor.selectEntered.AddListener(DebugPrint);
        _interactor.selectExited.AddListener(DebugPrint);
    }

    private void OnDisable()
    {
        _interactor.hoverEntered.RemoveListener(DebugPrint);
        _interactor.hoverExited.RemoveListener(DebugPrint);
        _interactor.selectEntered.RemoveListener(DebugPrint);
        _interactor.selectExited.RemoveListener(DebugPrint);
    }

    void DebugPrint(BaseInteractionEventArgs args)
    {
        Debug.Log(args.interactable.name + " " + args.interactor.name + " " + args.GetType().Name);
    }
}
