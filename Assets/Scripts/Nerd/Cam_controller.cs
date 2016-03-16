using UnityEngine;
using System.Collections;

public class Cam_controller : MonoBehaviour {

    Transform target, player;
    Vector3 to;

    // Use this for initialization
    void Start()
    {

        target = GameObject.Find("target").transform;
        player = GameObject.Find("nerd").transform;

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.Lerp(this.transform.position, target.position, 0.1f);

    }
}
