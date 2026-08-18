using UnityEngine;

public class Explosion : MonoBehaviour {
    [SerializeField]
    Animator animator;
    void Start() {
        animator.speed = Random.Range(.8f, 1.2f);
        Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update() {

    }
}
