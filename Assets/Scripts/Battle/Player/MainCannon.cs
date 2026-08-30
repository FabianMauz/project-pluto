using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainCannon : MonoBehaviour {

    [SerializeField]
    private GameController gameController;

    [SerializeField]
    private Projectile projectilePrefab;

    private DomainMainCannon mainCannon;

    private float currentReloadTime = 0;

    [SerializeField]
    private Transform projectileStartPoint;

    void Start() {
        mainCannon = gameController.domainPlayerShip.mainCanon;
    }

    void Update() {
        if (Mouse.current == null) return;

        if (currentReloadTime <= mainCannon.getReloadSpeed()) {
            currentReloadTime += Time.deltaTime;
            currentReloadTime = Math.Min(currentReloadTime, mainCannon.getReloadSpeed());

        }
        if (Mouse.current.leftButton.isPressed && currentReloadTime >= mainCannon.getReloadSpeed()) {
            currentReloadTime = 0;
            Projectile projectile = GameObject.Instantiate(projectilePrefab, projectileStartPoint.position, Quaternion.identity);
            Vector2 mouseScreenPosition = Mouse.current.position.ReadValue();
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mouseScreenPosition);

            Vector3 dPosition = mouseWorldPos - transform.position;
            dPosition.z = 0;
            projectile.initProjectile(3, dPosition.normalized, mainCannon.getDamage(), Target.ENEMY);
        }
    }


}
