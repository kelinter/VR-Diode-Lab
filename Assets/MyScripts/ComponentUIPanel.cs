using UnityEngine;

public class ComponentUIPanel : MonoBehaviour
{
    [SerializeField] private GameObject panelRoot;
    [SerializeField] private Camera targetCamera;

    private void Start()
    {
        if (panelRoot != null)
        {
            panelRoot.SetActive(false);
        }

        if (targetCamera == null && Camera.main != null)
        {
            targetCamera = Camera.main;
        }
    }

    private void LateUpdate()
    {
        if (panelRoot == null || !panelRoot.activeSelf || targetCamera == null)
        {
            return;
        }

        panelRoot.transform.LookAt(targetCamera.transform);

        // keep the panel facing the user correctly
        panelRoot.transform.Rotate(0f, 180f, 0f);
    }

    public void ShowPanel()
    {
        if (panelRoot != null)
        {
            panelRoot.SetActive(true);
        }
    }

    public void HidePanel()
    {
        if (panelRoot != null)
        {
            panelRoot.SetActive(false);
        }
    }
}
