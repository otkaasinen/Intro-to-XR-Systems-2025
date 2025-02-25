using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class ControlLensCamera : MonoBehaviour
{

    public Transform targetCamera;
    

    void Update()
    {
        Vector3 playerToLens = transform.position - targetCamera.position;
        transform.LookAt(transform.position + playerToLens, targetCamera.up);
        float zRotOffset = transform.localEulerAngles.z;
        transform.Rotate(0f, 0f, -zRotOffset, Space.Self);
        
    }
}
