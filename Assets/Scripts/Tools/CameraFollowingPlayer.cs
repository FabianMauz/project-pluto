using System;
using UnityEngine;


public class CameraFollowingPlayer : MonoBehaviour {

    [SerializeField]
    private Transform playerShip;

    private Camera camera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update() {

        Vector3 position = playerShip.position;
        position.z = -1;
        position.x = (float)Math.Clamp(position.x, -15.4, 15.4f);
        position.y = (float)Math.Clamp(position.y, -13, 13f);

        camera.transform.position = position;
    }
}
