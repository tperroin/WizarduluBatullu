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
        
        if(col.gameObject.name.Contains("burger"))
        {
            Destroy(transform.gameObject);

            Debug.Log("You WIN bitch !!!");
        } else
        {
            transform.Rotate(new Vector3(0, 10, 0));
            transform.Translate(new Vector3(10, 0, 0));
            Debug.Log(col.gameObject.name);
        }
    }
}
