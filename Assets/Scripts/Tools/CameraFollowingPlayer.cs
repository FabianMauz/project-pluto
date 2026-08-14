using System;
using UnityEngine;


public class CameraFollowingPlayer : MonoBehaviour {

    [SerializeField]
    private Transform playerShip;

    private Camera currentCamera;

    void Start() {
        currentCamera = Camera.main;
    }

    void Update() {

        Vector3 position = playerShip.position;
        position.z = -1;
        position.x = Math.Clamp(position.x, -15.4f, 15.4f);
        position.y = Math.Clamp(position.y, -13, 13f);

        currentCamera.transform.position = position;
    }
}
