using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour {
    [SerializeField]
    private AsteroidController asteroidController;

    [SerializeField]
    private SectorController sectorController;



    void Start() {
        triggerAsteroidFieldCreation();
        triggerAsteroidFieldCreation();
        triggerAsteroidFieldCreation();
    }

    private void triggerAsteroidFieldCreation() {
        SectorController.Sector sector = sectorController.getFreeSector();
        if (sector != SectorController.Sector.NONE) {
            sectorController.addAsteroids(
                sector, asteroidController.createAsteroidField(
                199,
                sectorController.getPositionOfSector(sector)));
        }
    }
}
