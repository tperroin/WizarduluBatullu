using UnityEngine;
using System.Collections;

public class run : MonoBehaviour
{

    public Animator anim;
    public Rigidbody rbody;
    private float inputH;
    private float inputV;
    private Vector3 moveDirection;


    void Start()
    {
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");

        anim.SetFloat("inputH", inputH);
        anim.SetFloat("inputV", inputV);

        float moveX = inputH * 50f * Time.deltaTime *10;
        float moveZ = inputV * 20f * Time.deltaTime*10;

        if(moveZ <= 0f)
        {
            moveX = 0f;
        }

        rbody.velocity = new Vector3(moveX, 0f, moveZ);

        //Convertis la direction de global à local
        moveDirection = transform.TransformDirection(moveDirection);

        //Rotation personnage
        this.transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * Time.deltaTime, 0));

        //La gravité d'un rigidbody ne fonctionne pas quand il y a un character controller
        //Gravité
        moveDirection.y -= 20f;
    }
	    
}
