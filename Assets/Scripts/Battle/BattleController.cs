using UnityEngine;

public class BattleController : MonoBehaviour {

    private AsteroidController asteroidController;
    void Start() {
        asteroidController = FindAnyObjectByType<AsteroidController>();

        triggerAsteroidFieldCreation();
        triggerAsteroidFieldCreation();
        triggerAsteroidFieldCreation();
    }

    private void triggerAsteroidFieldCreation() {
        asteroidController.createAsteroidField(
                1,
                this.transform);
    }


    private enum Sector {
        TOP_WEST, TOP_EAST, BUTTOM_WEST, BUTTOM_EAST
    }
}
