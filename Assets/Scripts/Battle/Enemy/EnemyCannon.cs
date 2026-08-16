using UnityEngine;

public class EnemyCannon : MonoBehaviour, EnemyWeapon {

    [SerializeField]
    private Projectile projectilePrefab;

    [SerializeField]
    private float range;

    [SerializeField]
    private float reloadSpeed;
    [SerializeField]
    private float fireRateDelay;

    [SerializeField]
    private int damage;
    private float currentReloadSpeed;
    private AimingTarget aimingTarget;

    public float getRange() {
        return range;
    }

    void Start() {
        aimingTarget = GetComponent<AimingTarget>();
    }


    void Update() {
        currentReloadSpeed += Time.deltaTime;
        if (currentReloadSpeed > reloadSpeed) {
            currentReloadSpeed = 0;
            GameObject target = aimingTarget.getTarget();
            if (target != null) {
                print("Target found");
            }
        }
    }
}
