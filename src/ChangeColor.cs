using UnityEngine;


public class ChangeColor : MonoBehaviour
{
    private Renderer rd;
    private Color originalColor;

    void Start()
    {
        rd = GetComponent<Renderer>();
        originalColor = rd.material.color;

        var interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
        interactable.selectEntered.AddListener(_ => rd.material.color = Color.red);
        interactable.selectExited.AddListener(_ => rd.material.color = originalColor);
    }
}
