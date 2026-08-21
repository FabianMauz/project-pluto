using UnityEngine;

public class Scout : MonoBehaviour, MovementStrategy {
    public Vector3 getNewTargetPosition() {
        return new Vector3(Random.Range(-12, 12), Random.Range(-12, 12), 0);
    }

    public bool hasReachedTargetPosition(Vector3 targetPosition, float targetReachedThresholdDistance) {
        return (transform.position - targetPosition).magnitude < targetReachedThresholdDistance;
    }
}
