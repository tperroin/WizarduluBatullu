using UnityEngine;
using System.Collections;

public class CollisionAI : MonoBehaviour {

    private GameController gameController;

	// Use this for initialization
	void Start () {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        
        if(col.gameObject.name.Contains("burger"))
        {
            Destroy(transform.gameObject);
            gameController.Win();
        } else if(col.gameObject.name.Contains("nerd"))
        {
            gameController.Lose();
        } else
        {
            transform.Rotate(new Vector3(0, 10, 0));
            transform.Translate(new Vector3(10, 0, 0));
        }
    }
}
