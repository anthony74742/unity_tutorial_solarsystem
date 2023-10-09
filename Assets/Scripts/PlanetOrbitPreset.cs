using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlanetOrbitPreset : ScriptableObject
{
    [Range(-100, 10000)]
    [Tooltip("Speed of rotation of the orbit in degrees per second")]
    public float OrbitalSpeed;

    [Range(0, 10000)]
    [Tooltip("Distance of the planet in Units")]
    public float OrbitRadius;

    [Tooltip("Reference to the prefab to instanciate within the orbit")]
    public GameObject PlanetPrefab;
}
