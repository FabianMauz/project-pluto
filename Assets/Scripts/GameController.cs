using UnityEngine;

public class GameController : MonoBehaviour {

    public DomainShip domainPlayerShip { get; private set; }
    void Start() {
        domainPlayerShip = new DomainShip();
    }
}
