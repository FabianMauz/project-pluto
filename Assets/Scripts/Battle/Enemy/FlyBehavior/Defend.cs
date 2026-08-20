using UnityEngine;

public class Defend : MonoBehaviour, MovementStrategy {

    [SerializeField]
    private GameObject targetObject;

    private GameObject player;

    [SerializeField]
    private float targetReachedThresholdDistance;

    public void initDefend(GameObject go) {
        targetObject = go;
        player = FindAnyObjectByType<PlayerShip>().gameObject;
    }
    public Vector3 getNewTargetPosition() {
        if (targetObject == null) {
            return player.gameObject.transform.position;
        }
        return targetObject.transform.position + new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), 0);
    }

    public bool hasReachedTargetPosition(Vector3 targetPosition) {

        if (targetObject == null) {
            return true;
        }
        return (transform.position - targetPosition).magnitude < targetReachedThresholdDistance;
    }
}

