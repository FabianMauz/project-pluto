using UnityEngine;

public class Asteroid : MonoBehaviour {
   [SerializeField]
   private ResouceSource resourceSource;

   public void initAsteroid(int resourceAmount) {
        resourceSource.setValue(resourceAmount);
    }
}
