using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour {

 [SerializeField]    private List<Asteroid> asteroids = new List<Asteroid>();
    [SerializeField] private Transform asteroidContainer;

    public IReadOnlyList<Asteroid> Asteroids => asteroids;

    [SerializeField] private Asteroid[] asteroidPrefabs;

    [SerializeField] float desity;


    public void removeAsteroid(ResouceSource asteroid) {
        asteroid.GetComponent<Vanishing>().startEffect();
        asteroids.Remove(asteroid.GetComponent<Asteroid>());
    }

    public void createAsteroidField(
        int resourceAmount,
        Transform locationCenter) {

        var position = new Vector3(locationCenter.position.x + Random.Range(0, desity),
        locationCenter.position.y + Random.Range(0, desity), 0);
        float sizeVariation = Random.Range(.5f, 1f);


        Asteroid asteroid = GameObject.Instantiate(asteroidPrefabs[0], position, Quaternion.identity);

        Vector3 scale = asteroid.transform.localScale;
        scale *= sizeVariation;
        asteroid.transform.localScale = scale;


        asteroid.gameObject.transform.SetParent(asteroidContainer);
        asteroid.initAsteroid(resourceAmount);
        asteroids.Add(asteroid);
    }
}
