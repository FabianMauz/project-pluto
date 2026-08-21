using UnityEngine;


public interface MovementStrategy {
    public Vector3 getNewTargetPosition();

    public bool hasReachedTargetPosition(Vector3 targetPosition,float targetReachedThresholdDistance);
}
