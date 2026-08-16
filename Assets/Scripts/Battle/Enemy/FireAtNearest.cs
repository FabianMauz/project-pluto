using UnityEngine;
[RequireComponent(typeof(EnemyWeapon))]
public class FireAtNearest : MonoBehaviour, AimingTarget {

    private BattleController battleController;


    private EnemyWeapon weapon;

    void Start() {
        battleController = FindAnyObjectByType<BattleController>();
        weapon = GetComponent<EnemyWeapon>();


    }
    public GameObject getTarget() {
        GameObject target = FindAnyObjectByType<PlayerShip>().gameObject;
        float distance = (target.transform.position - transform.position).magnitude;
        foreach (PlayerMissile missile in battleController.playerMissiles) {
            float newDistance = (missile.transform.position - transform.position).magnitude;
            if (newDistance < distance) {
                distance = newDistance;
                target = missile.gameObject;
            }
        }       
        
        return (distance <= weapon.getRange()) ? target : null;
    }
}

