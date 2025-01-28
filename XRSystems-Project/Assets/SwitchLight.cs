using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchLight : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    private Color defaultColor;
    private bool defaultColorOn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        action.action.Enable();
        light = GetComponent<Light>();
        defaultColor = light.color;
        defaultColorOn = true;
    }

    private void Update() {
        if (action.action.WasPressedThisFrame()) {
            if (defaultColorOn) {
                light.color = Color.red;
                defaultColorOn = false;
            } else 
            { 
                light.color = defaultColor;
                defaultColorOn = true;
            }
            }
    }


}
