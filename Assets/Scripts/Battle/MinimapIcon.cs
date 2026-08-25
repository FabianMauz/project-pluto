using UnityEngine;

public class MinimapIcon : MonoBehaviour {
    public Enemy enemy { get; private set; }
    private RectTransform rectTransform;

    private Vector2 a = new Vector2(4.5922f, 5.467f);
    private Vector2 b = new Vector2(500f, 251f);

    public void initIcon(Enemy enemy) {
        this.enemy = enemy;
        if (enemy.shipClass == Enemy.EnemyClass.ESCORT) {
            this.transform.localScale = new Vector3(.7f, .7f, .7f);
        }
    }

    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
    }

    private void LateUpdate() {
        if (enemy == null) {
            Destroy(gameObject);
            return;
        }

        float calculatedX = (a.x * enemy.transform.position.x) + b.x;
        float calculatedY = (a.y * enemy.transform.position.y) + b.y;
        Vector2 pos = rectTransform.anchoredPosition;
        pos.x = calculatedX;
        pos.y = calculatedY;
        rectTransform.anchoredPosition = pos;

        this.transform.rotation = enemy.transform.rotation;
    }
}