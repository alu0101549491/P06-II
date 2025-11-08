using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabMessage : MonoBehaviour
{
    void Start()
    {
        var interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        interactable.selectEntered.AddListener(OnGrab);
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        Debug.Log("Cubo cercano agarrado");
    }
}
