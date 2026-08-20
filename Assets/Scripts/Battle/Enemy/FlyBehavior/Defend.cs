using UnityEngine;

public class Defend : MonoBehaviour, MovementStrategy {

    private GameObject targetObject;

    public void initDefend(GameObject go) {
        targetObject = go;
    }
    public Vector3 getNewTargetPosition() {
        if (targetObject != null) {
            return Vector3.zero;
        }
        return targetObject.transform.position;
    }
}
