using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float rotationSpeed = 720f; 
    public float moveSpeed = 10f;
    private Vector2 moveInput;
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Update()
    {
       Vector3 moveDirection = new Vector3(moveInput.x, moveInput.y, 0);
    transform.position += moveDirection * moveSpeed * Time.deltaTime;

    if (moveDirection != Vector3.zero)
    {
        // Calculate the target rotation
        Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, moveDirection);
        
        // Smoothly rotate towards it
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
    }
}
