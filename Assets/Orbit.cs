using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{

    public PlanetOrbitPreset preset;
    [Tooltip("Child planet to move")]
    private GameObject Planet;

    private void Start()
    {
        this.Planet = GameObject.Instantiate(preset.PlanetPrefab, this.transform);
        this.Planet.name = preset.PlanetPrefab.name;

        //var sunmat = Resources.Load<Material>("Materials/sun");
        //this.Planet.GetComponentInChildren<MeshRenderer>().material = sunmat;


    }

    // Update is called once per frame
    void Update() 
    {
        this.Rotate();
        this.MovePlanetToRadius();
    }

    void MovePlanetToRadius()
    {
        this.Planet.transform.localPosition =
            new Vector3(this.preset.OrbitRadius, 0, 0);
    }

    void Rotate()
    {
        float angle = this.preset.OrbitalSpeed;
        float dt = Time.deltaTime;
        angle *= dt;

        if (GameController.Instance)
            angle = angle * GameController.Instance.Speed;


        this.transform.Rotate(Vector3.up, angle, Space.Self);

    }
}
