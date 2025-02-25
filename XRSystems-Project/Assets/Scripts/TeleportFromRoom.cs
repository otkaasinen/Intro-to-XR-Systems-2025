using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportFromRoom : MonoBehaviour
{

    public InputActionReference action;
    public Vector3 externalLocation;
    private Vector3 startLocation;

    private bool atStart;

    void Start() {
        action.action.Enable();
        atStart = true;
        startLocation = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (action.action.WasPressedThisFrame()) {
            if (atStart) {
                transform.SetPositionAndRotation(externalLocation, Quaternion.Euler(new Vector3(0,0,0)));
                atStart = false;
            }
            else {
                transform.SetPositionAndRotation(startLocation, Quaternion.Euler(new Vector3(0,0,0)));
                atStart = true;
            }
        }
    }
}
