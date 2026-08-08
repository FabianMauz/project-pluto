using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour {


    [SerializeField] private List<Asteroid> asteroids = new List<Asteroid>();
    public IReadOnlyList<Asteroid> Asteroids => asteroids;
}
