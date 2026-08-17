using UnityEngine;

public class Enemy : MonoBehaviour, Hitable {

    [SerializeField]
    private int baseHp;

    private float currentHp;


    public Target getTarget() {
        return Target.ENEMY;
    }

    public void takeDamage(float damage) {
        currentHp -= damage;
        if (currentHp < 0) {

            triggerDeath();
        }
    }

    private void triggerDeath() {
        FindAnyObjectByType<EnemyController>().removeEnemy(this);
        Destroy(this.gameObject);
    }
}
