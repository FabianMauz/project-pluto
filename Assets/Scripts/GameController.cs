using UnityEngine;

public class GameController : MonoBehaviour {

    public DomainShip domainPlayerShip { get; private set; }
    public Shop shop { get; private set; }
    void Start() {
        domainPlayerShip = new DomainShip();
        shop = new Shop(domainPlayerShip);
    }
}
