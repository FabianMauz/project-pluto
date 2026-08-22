using UnityEngine;
[RequireComponent(typeof(MovementStrategy))]
public class EnemyMovement : MonoBehaviour {
    [SerializeField]
    private float maxSpeed;

    [SerializeField]
    private float rotationSpeed;

    [SerializeField]
    private float acceleration;

    [SerializeField]
    private float targetReachedThresholdDistance;

    private Vector3 currentDirection;
    private Vector3 targetPosition;

    private MovementStrategy moveStrategy;

    private Vector3 currentSpeedVector;
    void Start() {
        moveStrategy = GetComponent<MovementStrategy>();
        targetPosition = moveStrategy.getNewTargetPosition();
        currentDirection = Vector3.up;
        currentSpeedVector = Vector3.zero;
    }

    public void setMovementStrategy(MovementStrategy strategy) {
        moveStrategy = strategy;
    }
    void Update() {
        if (moveStrategy.hasReachedTargetPosition(targetPosition, targetReachedThresholdDistance)) {
            targetPosition = moveStrategy.getNewTargetPosition();
        }


        Vector3 targetDirection = (targetPosition - transform.position).normalized;


        if (targetDirection != Vector3.zero) {
            currentDirection = Vector3.RotateTowards(
                currentDirection,
                targetDirection,
                rotationSpeed * Mathf.Deg2Rad * Time.deltaTime,
                0f
            ).normalized;
        }


        float angle = Mathf.Atan2(currentDirection.y, currentDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle - 90f);


        currentSpeedVector += currentDirection * acceleration * Time.deltaTime;
        currentSpeedVector = Vector3.ClampMagnitude(currentSpeedVector, maxSpeed);


        transform.position += currentSpeedVector * Time.deltaTime;
    }


}
