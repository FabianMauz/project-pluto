using System;
using UnityEngine;

public class GatheringDrone : MonoBehaviour {
    [SerializeField]
    private DroneState state;
    [SerializeField]
    private ResouceSource currentSource;
    [SerializeField]
    private Transform positionOnShip;

    [SerializeField]
    private float maxDistance;

    [SerializeField]
    private float maxSpeed;

    [SerializeField]
    private float DOCKING_DISTANCE = .5f;

    [SerializeField]
    private float HARVEST_DISTANCE = .5f;

    [Header("Harvesting Orbit Settings")]
    [SerializeField]
    private float orbitSpeed = 2f;
    [SerializeField]
    private float orbitRadius = 0.7f;
    private float orbitAngle;

    private float currentExtractionTime = 0;
    private float timeToExtractOneUnit = .5f;
    [SerializeField]
    private float currentExtractedValue = 0;
    private float maximumCapacity = 5;




    void Start() {
        state = DroneState.ON_SHIP;
    }

    void Update() {
        //Recall drone if target to far away from ship
        if (currentSource != null &&
            !isLockedSourceInRange()) {
            state = DroneState.FLIGHING_TO_SHIP;
            currentSource = null;
        }
        //Get next target
        if (currentSource == null && state == DroneState.ON_SHIP) {
            currentSource = getNearestResouceSource();
            if (currentSource != null) {
                state = DroneState.FLIGHING_TO_RESOURCE;
            }
        }

        if (state == DroneState.FLIGHING_TO_RESOURCE && isReadyToHarvest()) {
            state = DroneState.HARVESTING;
            if (currentSource != null) {
                Vector3 offset = transform.position - currentSource.transform.position;
                orbitAngle = Mathf.Atan2(offset.y, offset.x);
            }
        }

        if (state == DroneState.HARVESTING) {
            currentExtractionTime += Time.deltaTime;
            if (currentExtractionTime >= timeToExtractOneUnit) {
                currentExtractionTime = 0;
                currentExtractedValue += currentSource.extractResource(1);
                currentExtractedValue = Math.Min(currentExtractedValue, maximumCapacity);
                if (currentExtractedValue == maxDistance) {
                    state = DroneState.FLIGHING_TO_SHIP;
                }
            }
        }

        if (state == DroneState.FLIGHING_TO_SHIP && isReadyToDock()) {
            FindAnyObjectByType<PlayerShip>().transferResources(currentExtractedValue);
            currentExtractedValue = 0;
            currentSource=null;
            state = DroneState.ON_SHIP;
        }




        moveDrone();
    }


    private ResouceSource getNearestResouceSource() {
        ResouceSource[] possibleResources = FindObjectsByType<ResouceSource>(FindObjectsSortMode.None);

        if (possibleResources.Length > 0) {
            float distance = (possibleResources[0].gameObject.transform.position - positionOnShip.position).sqrMagnitude;

            if (distance < maxDistance) {
                return possibleResources[0];
            }
            else {
                return null;
            }
        }
        else {
            return null;
        }
    }

    private bool isReadyToDock() {
        float distance = (this.gameObject.transform.position - positionOnShip.position).sqrMagnitude;
        return distance < DOCKING_DISTANCE;
    }
    private bool isReadyToHarvest() {
        if (currentSource == null) {
            return false;
        }
        float distance = (this.gameObject.transform.position - currentSource.transform.position).sqrMagnitude;
        return distance < HARVEST_DISTANCE;
    }



    private void moveDrone() {
        Transform target = null;
        if (state == DroneState.HARVESTING) {
            if (currentSource == null) return;

            // Increment angle over time
            orbitAngle += orbitSpeed * Time.deltaTime;

            // Calculate 2D position relative to the resource target
            Vector3 offset = new Vector3(Mathf.Cos(orbitAngle), Mathf.Sin(orbitAngle), 0f) * orbitRadius;
            this.transform.position = currentSource.transform.position + offset;
            return;
        }
        if (state == DroneState.FLIGHING_TO_SHIP) {
            target = positionOnShip;
        }
        if (state == DroneState.FLIGHING_TO_RESOURCE) {
            if (currentSource == null) {
                return;
            }
            target = currentSource.transform;

        }

        if (state == DroneState.ON_SHIP) {
            this.transform.position = positionOnShip.position;
        }

        if (target != null) {
            Vector3 dPosition = (target.position - this.gameObject.transform.position).normalized;
            Vector3 oldPosition = transform.position;
            this.transform.position = oldPosition + dPosition * maxSpeed * Time.deltaTime;
        }
    }

    private bool isLockedSourceInRange() {
        if (currentSource == null) {
            return false;
        }

        float distance = (currentSource.gameObject.transform.position - positionOnShip.position).sqrMagnitude;
        return distance < maxDistance;
    }

    private enum DroneState {
        ON_SHIP,
        FLIGHING_TO_RESOURCE,
        FLIGHING_TO_SHIP,
        HARVESTING
    }
}
