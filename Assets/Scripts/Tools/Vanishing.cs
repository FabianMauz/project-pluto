using UnityEngine;

public class Vanishing : MonoBehaviour {
    [SerializeField]
    private float speed;

    [SerializeField]
    private SpriteRenderer sprite;

    private bool effectStarted = false;
    public void startEffect() {
        effectStarted = true;
    }

    void Update() {
        if (effectStarted) {
            Color color = sprite.color;
            color.a = color.a -= Time.deltaTime * speed;
            sprite.color = color;
        }
    }
}
