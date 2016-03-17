using UnityEngine;
using System.Collections;

public class SociereAI : MonoBehaviour {

    public Animator anim;
    private float inputH;
    private float inputV;
    private Vector3 moveDirection;
    private float deltaTime;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");
        deltaTime = Time.deltaTime;

        anim.SetFloat("inputH", inputH);
        anim.SetFloat("inputV", inputV);
    }
}
