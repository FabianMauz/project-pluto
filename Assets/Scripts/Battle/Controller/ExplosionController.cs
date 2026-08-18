using UnityEngine;

public class ExplosionController : MonoBehaviour {
    [SerializeField]
    private Explosion explosionPrefab;
    public void triggerExplosion(Vector3 position) {
        Instantiate(explosionPrefab, position, Quaternion.identity);
    }
}
