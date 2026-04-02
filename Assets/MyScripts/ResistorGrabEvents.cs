using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ResistorGrabEvents : MonoBehaviour
{
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable;
    private FloatRotate floatRotate;

    void Awake()
    {
        grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        floatRotate = GetComponent<FloatRotate>();
    }

    void OnEnable()
    {
        if (grabInteractable != null)
            grabInteractable.selectExited.AddListener(OnReleased);
    }

    void OnDisable()
    {
        if (grabInteractable != null)
            grabInteractable.selectExited.RemoveListener(OnReleased);
    }

    private void OnReleased(SelectExitEventArgs args)
    {
        if (floatRotate != null)
            floatRotate.ResetFloatOrigin();
    }
}
