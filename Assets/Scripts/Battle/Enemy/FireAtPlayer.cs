using UnityEngine;

public class FireAtPlayer : MonoBehaviour, AimingTarget {

    private GameObject player;
    void Start() {
        player = FindAnyObjectByType<PlayerShip>().gameObject;
    }
    public GameObject getTarget() {
        return player;
    }
}
