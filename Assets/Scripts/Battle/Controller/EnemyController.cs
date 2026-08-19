using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    [SerializeField]
    private float density;

    [SerializeField]
    private Transform enemyContainer;
    [SerializeField]
    private Enemy[] enemyPrefabs;

    [SerializeField]
    private SectorController sectorController;

    private List<Enemy> enemies = new List<Enemy>();
    public void removeEnemy(Enemy enemy) {
        enemies.Remove(enemy);
    }

    public void createEnemyWave(int threadValue, int wave, SectorController.Sector sector) {


        while (threadValue > 0) {
            Vector3 position = calculatePosition(sector);

            if (Random.Range(0, 100) < 50) {
                threadValue -= 2;

                Enemy enemy = Instantiate(enemyPrefabs[0], position, Quaternion.identity);
                enemies.Add(enemy);
                enemy.transform.SetParent(enemyContainer);
            }
        }

    }

    private Vector3 calculatePosition(SectorController.Sector sector) {
        Vector3 position = sectorController.getPositionOfSector(sector).position;
        Vector2 random2D = Random.insideUnitCircle * density;
        position.x += random2D.x;
        position.y += random2D.y;
        return position;
    }
}
