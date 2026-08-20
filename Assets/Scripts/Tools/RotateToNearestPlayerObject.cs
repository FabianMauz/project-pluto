using UnityEngine;

public class RotateToNearestPlayerObject : MonoBehaviour {

    [SerializeField]
    private float spriteAngleOffset;
    BattleController battleController;
    void Start() {
        battleController = FindAnyObjectByType<BattleController>();
    }
    void Update() {
        GameObject target = FindAnyObjectByType<PlayerShip>().gameObject;
        float distance = (target.transform.position - transform.position).magnitude;
        foreach (PlayerMissile missile in battleController.playerMissiles) {
            float newDistance = (missile.transform.position - transform.position).magnitude;
            if (newDistance < distance) {
                distance = newDistance;
                target = missile.gameObject;
            }
        }

        Vector2 direction = target.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, angle + spriteAngleOffset);
    }
}
