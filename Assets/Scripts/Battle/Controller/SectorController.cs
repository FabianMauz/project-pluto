using System;
using System.Collections.Generic;
using UnityEngine;

public class SectorController : MonoBehaviour {

    private Dictionary<Sector, List<Asteroid>> sectors = new Dictionary<Sector, List<Asteroid>>();
    [SerializeField]
    private Transform[] sectorsTransforms;
    private Dictionary<Sector, Transform> sectorPositions = new Dictionary<Sector, Transform>();
    void Start() {
        sectorPositions.Add(Sector.TOP_WEST, sectorsTransforms[0]);
        sectorPositions.Add(Sector.TOP_EAST, sectorsTransforms[1]);
        sectorPositions.Add(Sector.BOTTOM_WEST, sectorsTransforms[2]);
        sectorPositions.Add(Sector.BOTTOM_EAST, sectorsTransforms[3]);


        sectors.Add(Sector.TOP_WEST, new List<Asteroid>());
        sectors.Add(Sector.TOP_EAST, new List<Asteroid>());
        sectors.Add(Sector.BOTTOM_EAST, new List<Asteroid>());
        sectors.Add(Sector.BOTTOM_WEST, new List<Asteroid>());
    }

    public Transform getPositionOfSector(Sector sector) {
        return sectorPositions[sector];
    }

    // Update is called once per frame
    void Update() {

    }

    public void addAsteroids(Sector targetSector, List<Asteroid> asteroids) {
        sectors[targetSector] = asteroids;
    }

    public void removeAsteroid(Asteroid asteroid) {
        foreach (Sector type in Enum.GetValues(typeof(Sector))) {
            if (type != Sector.NONE) {
                sectors[type].Remove(asteroid);
            }
        }
    }

    public Sector getFreeSector() {
        List<Sector> freeSectors = new List<Sector>();
        foreach (Sector type in Enum.GetValues(typeof(Sector))) {
            if (type != Sector.NONE && sectors[type].Count == 0) {
                freeSectors.Add(type);
            }
        }
        if (freeSectors.Count == 0) {
            return Sector.NONE;
        }
        return freeSectors[UnityEngine.Random.Range(0, freeSectors.Count)];

    }

    public enum Sector {
        TOP_WEST, TOP_EAST, BOTTOM_WEST, BOTTOM_EAST, NONE
    }
}
