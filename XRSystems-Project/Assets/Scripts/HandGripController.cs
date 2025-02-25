using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

public class HandController : MonoBehaviour
{

    public InputActionReference action;
    public Hand hand;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        action.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        hand.SetGrip(action.action.ReadValue<float>());
    }
}
