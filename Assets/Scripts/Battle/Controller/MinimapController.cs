using System.Collections.Generic;
using UnityEngine;

public class MinimapController : MonoBehaviour {
    [SerializeField]
    private Transform minimapContainer;
    private List<MinimapIcon> minimapIcons = new List<MinimapIcon>();
    [SerializeField]
    private MinimapIcon[] prefabs;

    void Start() {
        MinimapIcon playerIcon = Instantiate(prefabs[1], minimapContainer.position, Quaternion.identity);
        playerIcon.initIcon(FindAnyObjectByType<PlayerShip>());
        playerIcon.transform.SetParent(minimapContainer);
        minimapIcons.Add(playerIcon);
    }

    public void createMiniMapIcon(Enemy enemy) {
        MinimapIcon icon = Instantiate(prefabs[0], minimapContainer.position, Quaternion.identity);
        icon.initIcon(enemy);
        icon.transform.SetParent(minimapContainer);
        minimapIcons.Add(icon);
    }

     public void createMiniMapIcon(Asteroid asteroid) {
        MinimapIcon icon = Instantiate(prefabs[2], minimapContainer.position, Quaternion.identity);
        icon.initIcon(asteroid);
        icon.transform.SetParent(minimapContainer);
        minimapIcons.Add(icon);
    }

    public void removeMinimapIcon(Enemy enemy) {
        foreach (MinimapIcon icon in minimapIcons) {
            if (icon.enemy == enemy) {
                minimapIcons.Remove(icon);
                Destroy(icon.gameObject);
            }
        }
    }
}
