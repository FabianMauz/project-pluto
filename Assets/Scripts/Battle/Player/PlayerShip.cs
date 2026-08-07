using UnityEngine;

public class PlayerShip : MonoBehaviour {
    [SerializeField]
    private float resources;

    public void transferResources(float value) {
        this.resources+=value;
    }

}
