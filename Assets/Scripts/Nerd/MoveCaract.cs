using UnityEngine;
using System.Collections;

public class MoveCaract : MonoBehaviour
{

    public float speed = 10f;
    public float gravity = 20f;

    private CharacterController controller;
    private Vector3 moveDirection;
    private float deltaTime;
    private GameObject anim;


    // Use this for initialization
    void Start()
    {

        controller = GetComponent<CharacterController>();
        anim = GameObject.Find("nerd");

    }

    // Update is called once per frame
    void Update()
    {
        deltaTime = Time.deltaTime;

        if (Input.GetAxis("Vertical") != 0)
        {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical") * speed);
        }

        anim.GetComponent<Animation>().CrossFade("idle", 0.2f);

        //Convertis la direction de global à local
        moveDirection = transform.TransformDirection(moveDirection);

        //Rotation personnage
        this.transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * deltaTime, 0));

        //La gravité d'un rigidbody ne fonctionne pas quand il y a un character controller
        //Gravité
        moveDirection.y -= gravity;

        //Application des directions au Character Controller
        controller.Move(moveDirection * deltaTime);

    }
}
