# P06-II

![Ejercicio 1](samples/Exercise1.gif)

En esta práctica se configuró un entorno XR en Unity utilizando el Meta XR Simulator para probar la interacción sin necesidad del visor físico. Se implementaron dos tipos de interacciones: una interacción directa, en la que el usuario puede agarrar un cubo cercano con la mano virtual, y una interacción a distancia mediante un *Ray Interactor*, que permite cambiar el color de otro cubo a una distancia lejana.

## GrabMessage.cs

```cs
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
```

## ChangeColor.cs

```cs
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
```