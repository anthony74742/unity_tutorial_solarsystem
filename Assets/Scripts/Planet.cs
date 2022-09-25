using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{

    public float distanceFromOrbit;
    public float bodySize;
    public bool activateTrail;

    public GameObject body;
    private TrailRenderer _trail;

    // Start is called before the first frame update
    void Start()
    {
        this._trail = this.gameObject.GetComponent<TrailRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localPosition = new Vector3(this.distanceFromOrbit, 0, 0);
        this.body.transform.localScale = new Vector3(this.bodySize, this.bodySize, this.bodySize);

        if (this._trail != null)
            this._trail.enabled = this.activateTrail;
    }
}
