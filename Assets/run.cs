using UnityEngine;
using System.Collections;

public class run : MonoBehaviour
{

    public Animator anim;
    private float inputH;
    private float inputV;
    private Vector3 moveDirection;
    private CharacterController controller;
    private float deltaTime;

    void Start()
    {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {

        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");
        deltaTime = Time.deltaTime;

        anim.SetFloat("inputH", inputH);
        anim.SetFloat("inputV", inputV);

        float moveX = inputH * 50f * Time.deltaTime * 10;
        float moveZ = inputV * 50f * Time.deltaTime * 20;

        if (moveZ <= 0f)
        {
            moveX = 0f;
        }

        //Convertis la direction de global à local
        moveDirection = transform.TransformDirection(moveDirection);

        //Rotation personnage
        this.transform.Rotate(new Vector3(0, inputH * deltaTime * 30f, 0));

        this.transform.Translate(new Vector3(0, 0, inputV * deltaTime * 30f));

        //La gravité d'un rigidbody ne fonctionne pas quand il y a un character controller
        //Gravité
        moveDirection.y -= 20f;

        //Application des directions au Character Controller
        controller.Move(moveDirection * deltaTime);

        if(Input.GetKeyDown("space"))
        {
            anim.Play("fire", -1, 0f);
        }
    }
}
