using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : MonoBehaviour, Hitable {

    [SerializeField]
    private int baseHp;
    [SerializeField]
    private int hpBonusPerWave;

    private float currentHp;
    public EnemyClass shipClass { private set; get; }


    public void initEnemy(int wave, EnemyClass shipClass) {
        currentHp = baseHp + wave * hpBonusPerWave;
        this.shipClass = shipClass;
    }

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

    public enum EnemyClass {
        CANNON_TURRET,
        SCOUT,
        ESCORT,
        CRUISER,
        MISSILE_TURRET,
        BATTLE_CRUISER,
        SPACE_STATION,
        BATTLE_SHIP,
        SPACE_FORTRESS


    }
}
