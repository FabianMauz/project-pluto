using System;
using UnityEngine;

public class ResouceSource : MonoBehaviour {

    [SerializeField]
    private float value;

    public float extractResource(float valueToExtract) {
        float extractedValue = Math.Min(value, valueToExtract);
        value -= extractedValue;
        return extractedValue;
    }
}
