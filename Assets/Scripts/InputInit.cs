using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class InputInit : MonoBehaviour
{
    void Awake()
    {
        // Enable Enhanced Touch Support biar Ground Plane bisa baca tap layar
        EnhancedTouchSupport.Enable();
    }
}
