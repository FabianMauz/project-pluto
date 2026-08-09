using UnityEngine;

public class Rotatiing : MonoBehaviour {

    private Vector3 rotationSpeed;
    [Header("Min and Max Rotation values")]
    [SerializeField]
    private Vector2 minMaxRotationSpeed;


    void Start() {
        float speed = Random.Range(minMaxRotationSpeed[0], minMaxRotationSpeed[1]);
        if (Random.Range(0, 100) < 50) {
            speed = speed * -1;
        }
        rotationSpeed = new Vector3(0f, 0f, speed);
        print(rotationSpeed);
    }
    void Update() {
        transform.Rotate(rotationSpeed * Time.deltaTime, Space.Self);
    }
}
