using UnityEngine;

public class BattleController : MonoBehaviour {
    [SerializeField]
    private AsteroidController asteroidController;

    [SerializeField]
    private SectorController sectorController;

    private float currentWaveProgress = 0;

    [SerializeField]
    private float maxWaveProgress = 60;
    private int currentWave = 0;


    void Update() {
        currentWaveProgress += Time.deltaTime;
        if (currentWaveProgress > maxWaveProgress) {
            currentWaveProgress = 0;
            triggerNextWave();
        }
    }


    void Start() {
        triggerNextWave();
    }

    private void triggerEnemyCreation(SectorController.Sector sector) {

    }

    private void triggerNextWave() {
        SectorController.Sector freeSector = sectorController.getFreeSector();
        if (freeSector != SectorController.Sector.NONE) {
            triggerEnemyCreation(freeSector);
            triggerAsteroidFieldCreation(freeSector);
        }
    }

    private void triggerAsteroidFieldCreation(SectorController.Sector sector) {
        sectorController.addAsteroids(
            sector,
            asteroidController.createAsteroidField(
                30 + currentWave * 10,
                sectorController.getPositionOfSector(sector)));
    }
}
