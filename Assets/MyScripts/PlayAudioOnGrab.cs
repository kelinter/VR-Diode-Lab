using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class PlayAudioOnGrab : MonoBehaviour
{
    private AudioSource audioSource;
    private XRGrabInteractable grabInteractable;
    private Rigidbody rb;
    private FloatRotate floatRotate;

    [SerializeField] private Transform homePoint;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        grabInteractable = GetComponent<XRGrabInteractable>();
        rb = GetComponent<Rigidbody>();
        floatRotate = GetComponent<FloatRotate>();

        grabInteractable.selectEntered.AddListener(OnGrab);
        grabInteractable.selectExited.AddListener(OnRelease);
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        if (audioSource != null)
        {
            audioSource.Stop();
            audioSource.Play();
        }

        if (floatRotate != null)
        {
            floatRotate.enabled = false;
        }
    }

    void OnRelease(SelectExitEventArgs args)
    {
        if (audioSource != null)
        {
            audioSource.Stop();
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
