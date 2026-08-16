using UnityEngine;

public class RotationToPlayer : MonoBehaviour {

    private Transform playerShip;


    [SerializeField] private float spriteAngleOffset = -90f;


    void Start() {
        playerShip = FindAnyObjectByType<PlayerShip>().transform;
    }

    void Update() {
        Vector2 direction = playerShip.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle + spriteAngleOffset);
    }
}
