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
    [SerializeField]
    private BattleController battleController;

    [SerializeField]
    private MinimapController minimapController;


    private List<Enemy> enemies = new List<Enemy>();
    public void removeEnemy(Enemy enemy) {
        enemies.Remove(enemy);
    }

    public void createEnemyWave(int threadValue, int wave, SectorController.Sector sector) {


        while (threadValue > 0) {
            Vector3 position = calculatePosition(sector);

            if (threadValue >= 14) {
                threadValue -= 14;
                createCruiserFleet(position);
            }

            else if (threadValue >= 11) {
                threadValue -= 11;
                createCannonTurretFleet(position);
            }
            else if (threadValue >= 3) {
                threadValue -= 3;
                createSingleEscort(null, position);
            }
            else {
                threadValue -= 2;
                createSingleScout(position);
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

    private void createCruiserFleet(Vector3 position) {
        Enemy cruiser = Instantiate(enemyPrefabs[3], position, Quaternion.identity);
        Patrouling d = cruiser.GetComponent<Patrouling>();
        cruiser.GetComponent<EnemyMovement>().setMovementStrategy(d);
        cruiser.initEnemy(battleController.currentWave, Enemy.EnemyClass.CRUISER);
        cruiser.transform.SetParent(enemyContainer);
        enemies.Add(cruiser);
        minimapController.createMiniMapIcon(cruiser);

        createSingleEscort(cruiser.gameObject, position);
        createSingleEscort(cruiser.gameObject, position);
        createSingleEscort(cruiser.gameObject, position);
    }

    private void createCannonTurretFleet(Vector3 position) {
        Enemy turret = Instantiate(enemyPrefabs[0], position, Quaternion.identity);
        enemies.Add(turret);
        turret.transform.SetParent(enemyContainer);
        turret.initEnemy(battleController.currentWave, Enemy.EnemyClass.CANNON_TURRET);
        minimapController.createMiniMapIcon(turret);

        createSingleEscort(turret.gameObject, position);
        createSingleEscort(turret.gameObject, position);
        createSingleEscort(turret.gameObject, position);
    }

    private void createSingleScout(Vector3 position) {
        Enemy scout = Instantiate(enemyPrefabs[1], position, Quaternion.identity);
        enemies.Add(scout);
        scout.transform.SetParent(enemyContainer);
        scout.initEnemy(battleController.currentWave, Enemy.EnemyClass.SCOUT);
        minimapController.createMiniMapIcon(scout);
    }

    private void createSingleEscort(GameObject shipToDefend, Vector3 position) {
        Enemy escort = Instantiate(enemyPrefabs[2], position, Quaternion.identity);
        enemies.Add(escort);
        escort.transform.SetParent(enemyContainer);
        escort.initEnemy(battleController.currentWave, Enemy.EnemyClass.ESCORT);
        escort.GetComponent<Defend>().initDefend(shipToDefend);
        minimapController.createMiniMapIcon(escort);
    }
}
