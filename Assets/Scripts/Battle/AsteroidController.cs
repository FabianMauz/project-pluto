using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour {

    [SerializeField] private List<Asteroid> asteroids = new List<Asteroid>();
    [SerializeField] private Transform asteroidContainer;

    public IReadOnlyList<Asteroid> Asteroids => asteroids;

    [SerializeField] private Asteroid[] asteroidPrefabs;

    [SerializeField] float desity;


    public void removeAsteroid(ResouceSource asteroid) {
        asteroid.GetComponent<Vanishing>().startEffect();
        asteroids.Remove(asteroid.GetComponent<Asteroid>());
    }

    public List<Asteroid> createAsteroidField(
        int resourceAmount,
        Transform locationCenter) {
        List<Asteroid> createdAsteroids = new List<Asteroid>();

        int resourceLeft = resourceAmount;
        Asteroid asteroid;
        while (resourceLeft > 0) {
            if (resourceLeft >= 50) {
                resourceLeft -= 50;
                asteroid = createBigAsteroid(locationCenter);
            }
            else if (resourceLeft >= 15 && Random.Range(0, 100) < 50) {
                resourceLeft -= 15;
                asteroid = createMediumAsteroid(locationCenter);
            }
            else {
                resourceLeft -= 5;
                asteroid = createSmallAsteroid(locationCenter);
            }


            asteroids.Add(asteroid);
            createdAsteroids.Add(asteroid);
        }
        return createdAsteroids;
    }

    private Asteroid createBigAsteroid(Transform locationCenter) {
        var position = new Vector3(
            locationCenter.position.x + Random.Range(0, desity),
            locationCenter.position.y + Random.Range(0, desity),
            0);
        float sizeVariation = Random.Range(.9f, 1f);
        return createAsteroid(sizeVariation, position, 50);
    }
    private Asteroid createMediumAsteroid(Transform locationCenter) {
        var position = new Vector3(
            locationCenter.position.x + Random.Range(0, desity),
            locationCenter.position.y + Random.Range(0, desity),
            0);
        float sizeVariation = Random.Range(.5f, .7f);
        return createAsteroid(sizeVariation, position, 15);
    }
    private Asteroid createSmallAsteroid(Transform locationCenter) {
        var position = new Vector3(
            locationCenter.position.x + Random.Range(0, desity),
            locationCenter.position.y + Random.Range(0, desity),
            0);
        float sizeVariation = Random.Range(.25f, .4f);
        return createAsteroid(sizeVariation, position, 5);
    }

    private Asteroid createAsteroid(float sizeVariation, Vector3 position, int resourceAmount) {
        Asteroid asteroid = Instantiate(asteroidPrefabs[0], position, Quaternion.identity);

        Vector3 scale = asteroid.transform.localScale;
        scale *= sizeVariation;
        asteroid.transform.localScale = scale;


        asteroid.gameObject.transform.SetParent(asteroidContainer);
        asteroid.initAsteroid(resourceAmount);
        return asteroid;
    }
}
