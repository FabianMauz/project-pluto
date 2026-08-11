using UnityEngine;
using UnityEngine.InputSystem;

public class RotationToMouse : MonoBehaviour {
    [Header("Settings")]
    [Tooltip("Set to -90 if your sprite naturally points UP, or 0 if it naturally points RIGHT.")]
    [SerializeField] private float spriteAngleOffset = -90f;
    private Camera mainCamera;

    private void Start() {
        mainCamera = Camera.main;
    }

    private void Update() {
        RotateTowardsMouse();
    }

    private void RotateTowardsMouse() {
        // 2. Check if a mouse device is present
        if (Mouse.current == null) return;

        // 3. Read mouse position using New Input System
        Vector2 mouseScreenPosition = Mouse.current.position.ReadValue();

        // 4. Convert screen position to 2D world space
        Vector3 mouseWorldPos = mainCamera.ScreenToWorldPoint(mouseScreenPosition);

        // 5. Calculate direction vector from cannon pivot to mouse
        Vector2 direction = mouseWorldPos - transform.position;

        // 6. Convert direction vector to angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // 7. Apply rotation around Z-axis
        transform.rotation = Quaternion.Euler(0f, 0f, angle + spriteAngleOffset);
    }
}
