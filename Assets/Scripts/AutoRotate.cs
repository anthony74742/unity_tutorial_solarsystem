using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AUTO", menuName = "SPACE/Auto")]
public class AutoRotate : MonoBehaviour
{
    /// <summary>
    /// Angular speed of the object in degrees per second
    /// </summary>
    [Tooltip("Angular speed of the object in degrees per second.")]
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float angle = this.speed;
        float dt = Time.deltaTime;
        angle *= dt;

        if (GameController.Instance)
            angle = angle * GameController.Instance.Speed;


        this.transform.Rotate(Vector3.up, angle, Space.Self);
    }
}
