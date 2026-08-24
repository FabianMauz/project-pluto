using UnityEngine;

public class MinimapIcon : MonoBehaviour {
    public Enemy enemy { get; private set; }
    private RectTransform rectTransform;

    private float xA = 0.21776f;
    private float xB = 380.25f;

    public void initIcon(Enemy enemy) {
        this.enemy = enemy;
    }

    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
    }

    private void LateUpdate() {
        if (enemy == null) {
            Destroy(gameObject);
            return;
        }

        float calculatedX = (xA * enemy.transform.position.x) + xB;

        // Apply using anchoredPosition for UI RectTransforms
        Vector2 pos = rectTransform.anchoredPosition;
        pos.x = calculatedX;
        rectTransform.anchoredPosition = pos;
        print("Enemy x: " + enemy.transform.position + " Icon x:" + calculatedX);
    }
}