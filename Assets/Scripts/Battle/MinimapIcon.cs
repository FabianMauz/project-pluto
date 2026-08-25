using UnityEngine;

public class MinimapIcon : MonoBehaviour {
    public Enemy enemy { get; private set; }
    public Asteroid asteroid { get; private set; }
    public PlayerShip player { get; private set; }
    private RectTransform rectTransform;

    private Vector2 a = new Vector2(4.5922f, 5.467f);
    private Vector2 b = new Vector2(500f, 251f);

    public void initIcon(Enemy enemy) {
        this.enemy = enemy;
        if (enemy.shipClass == Enemy.EnemyClass.ESCORT) {
            this.transform.localScale = new Vector3(.7f, .7f, .7f);
        }
    }
    public void initIcon(Asteroid asteroid) {
        this.asteroid = asteroid;

    }

    public void initIcon(PlayerShip player) {
        this.player = player;
    }

    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
    }

    private void LateUpdate() {
        if (enemy == null && player == null && asteroid == null) {
            Destroy(gameObject);
            return;
        }

        if (enemy != null) {
            float calculatedX = (a.x * enemy.transform.position.x) + b.x;
            float calculatedY = (a.y * enemy.transform.position.y) + b.y;
            Vector2 pos = rectTransform.anchoredPosition;
            pos.x = calculatedX;
            pos.y = calculatedY;
            rectTransform.anchoredPosition = pos;
            transform.rotation = enemy.transform.rotation;
        }
        else if (asteroid == null) {
            float calculatedX = (a.x * player.transform.position.x) + b.x;
            float calculatedY = (a.y * player.transform.position.y) + b.y;
            Vector2 pos = rectTransform.anchoredPosition;
            pos.x = calculatedX;
            pos.y = calculatedY;
            rectTransform.anchoredPosition = pos;
            transform.rotation = player.transform.rotation;
        }
        else {
            float calculatedX = (a.x * asteroid.transform.position.x) + b.x;
            float calculatedY = (a.y * asteroid.transform.position.y) + b.y;
            Vector2 pos = rectTransform.anchoredPosition;
            pos.x = calculatedX;
            pos.y = calculatedY;
            rectTransform.anchoredPosition = pos;
        }


    }
}