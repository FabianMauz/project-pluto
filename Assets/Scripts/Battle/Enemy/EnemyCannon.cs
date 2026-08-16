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
    [SerializeField]
    private Transform projectileStartPoint;

    public float getRange() {
        return range;
    }

    void Start() {
        aimingTarget = GetComponent<AimingTarget>();
        currentReloadSpeed=reloadSpeed*fireRateDelay;
    }


    void Update() {
        currentReloadSpeed += Time.deltaTime;
        if (currentReloadSpeed > reloadSpeed) {
            currentReloadSpeed = 0;
            GameObject target = aimingTarget.getTarget();
            if (target != null) {
                Projectile projectile = Instantiate(projectilePrefab, projectileStartPoint.position, Quaternion.identity);

                projectile.initProjectile(
                    4,
                    (target.transform.position - this.transform.position).normalized, damage,
                    Target.PLAYER);
            }
        }
    }
}
