using UnityEngine;

public class Projectile : MonoBehaviour {
    private Target target;
    private Vector3 dPosition;

    private float damage;

    [SerializeField]
    private float speed;

    public void initProjectile(float duration, Vector3 dPosition, float damage, Target target) {
        Destroy(gameObject, duration);
        this.dPosition = dPosition;
        this.target = target;
        this.damage = damage;
        float angle = Mathf.Atan2(dPosition.y, dPosition.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle + 90);
    }
    void Update() {
        Vector3 position = transform.position;
        position += Time.deltaTime * speed * dPosition;
        transform.position = position;
    }
}
