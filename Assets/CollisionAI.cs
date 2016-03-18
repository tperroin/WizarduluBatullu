using UnityEngine;
using System.Collections;

public class CollisionAI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        transform.Rotate(new Vector3(0, 5, 0));
        Debug.Log(col.gameObject.name);
        //if (!col.gameObject.name.Equals("nerd"))
        //    Destroy(transform.gameObject);
    }
}
