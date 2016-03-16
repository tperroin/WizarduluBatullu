using UnityEngine;
using System.Collections;

public class Cam_controller : MonoBehaviour {

    Transform target, player;
    Vector3 to;

    // Use this for initialization
    void Start()
    {
        
        player = GameObject.Find("nerd").transform;

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("t"))
        {
            this.transform.Translate(new Vector3(0, 0, 20));

            this.transform.Rotate(new Vector3(0, 180, 0));

        }

    }
}
