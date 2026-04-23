using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class PlayAudioOnGrab : MonoBehaviour
{
    private AudioSource audioSource;
    private XRGrabInteractable grabInteractable;
    private Rigidbody rb;
    private FloatRotate floatRotate;
    private ComponentUIPanel uiPanel;

    [SerializeField] private Transform homePoint;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        grabInteractable = GetComponent<XRGrabInteractable>();
        rb = GetComponent<Rigidbody>();
        floatRotate = GetComponent<FloatRotate>();
        uiPanel = GetComponent<ComponentUIPanel>();
    }

    private void OnEnable()
    {
        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.AddListener(OnGrab);
            grabInteractable.selectExited.AddListener(OnRelease);
        }
    }

    private void OnDisable()
    {
        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.RemoveListener(OnGrab);
            grabInteractable.selectExited.RemoveListener(OnRelease);
        }
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        if (audioSource != null)
        {
            audioSource.Stop();
            audioSource.time = 0f;
            audioSource.Play();
        }

        if (uiPanel != null)
        {
            uiPanel.ShowPanel();
        }

        if (floatRotate != null)
        {
            floatRotate.enabled = false;
        }
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        if (audioSource != null)
        {
            audioSource.Stop();
            audioSource.time = 0f;
        }

        if (uiPanel != null)
        {
            uiPanel.HidePanel();
        }

        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        if (homePoint != null)
        {
            transform.position = homePoint.position;
            transform.rotation = homePoint.rotation;
        }

        if (floatRotate != null)
        {
            floatRotate.ResetFloatOrigin();
            floatRotate.enabled = true;
        }
    }
}
