using UnityEngine;


public class FloatRotate : MonoBehaviour
{
    public float floatHeight = 0.1f;
    public float floatSpeed = 1f;
    public float rotateSpeed = 30f;

    private Vector3 startPos;
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable;

    void Start()
    {
        startPos = transform.position;
        grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
    }

    void Update()
    {
        // do not float/rotate while being grabbed
        if (grabInteractable != null && grabInteractable.isSelected)
            return;

        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector3(startPos.x, newY, startPos.z);

        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }

    public void ResetFloatOrigin()
    {
        startPos = transform.position;
    }
}
