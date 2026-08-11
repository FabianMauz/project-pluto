using System;
using UnityEngine;

public class PlayerShip : MonoBehaviour {
    [SerializeField]
    private float resources;

    [SerializeField]
    private GameObject[] mainWeapons;

    [SerializeField]
    private GameController gameController;

    void Start() {
        foreach (GameObject weapon in mainWeapons) {
            weapon.SetActive(false);
        }

        if (gameController.domainPlayerShip.mainCanon.amount == DomainMainCannon.MainCannonAmount.ONE) {
            mainWeapons[0].SetActive(true);
        }
        if (gameController.domainPlayerShip.mainCanon.amount == DomainMainCannon.MainCannonAmount.TWO) {
            mainWeapons[1].SetActive(true);
            mainWeapons[2].SetActive(true);
        }
        if (gameController.domainPlayerShip.mainCanon.amount == DomainMainCannon.MainCannonAmount.FOUR) {
            mainWeapons[1].SetActive(true);
            mainWeapons[2].SetActive(true);
            mainWeapons[3].SetActive(true);
            mainWeapons[4].SetActive(true);
        }
    }

    public void transferResources(float value) {
        this.resources += value;
    }

}
