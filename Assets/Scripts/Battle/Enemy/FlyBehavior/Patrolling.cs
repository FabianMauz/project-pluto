using UnityEngine;

public class Patrouling : MonoBehaviour, MovementStrategy {

    public SectorController.Sector sector;

    public void setSector(SectorController.Sector sector) {
        this.sector = sector;
    }
    public Vector3 getNewTargetPosition() {
        return new Vector3(Random.Range(-12, 12), Random.Range(-12, 12), 0);
    }

    public bool hasReachedTargetPosition(Vector3 targetPosition, float targetReachedThresholdDistance) {
        return (transform.position - targetPosition).magnitude < targetReachedThresholdDistance;
    }
}
