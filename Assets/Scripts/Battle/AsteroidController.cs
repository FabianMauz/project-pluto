using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour {


    private List<Asteroid> asteroids = new List<Asteroid>();
    [SerializeField] private Transform asteroidContainer;

    public IReadOnlyList<Asteroid> Asteroids => asteroids;

    [SerializeField] private Asteroid[] asteroidPrefabs;

    [SerializeField] float desity;


    public void createAsteroidField(
        int resourceAmount,
        Transform locationCenter) {
        var position = new Vector3(locationCenter.position.x + Random.Range(0, desity),
        locationCenter.position.y + Random.Range(0, desity), 0);
        Asteroid asteroid = GameObject.Instantiate(asteroidPrefabs[0], position, Quaternion.identity);
        asteroid.gameObject.transform.SetParent(asteroidContainer);

        asteroids.Add(asteroid);
    }
}
