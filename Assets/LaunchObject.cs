using UnityEngine;
using System.Collections;

public class LaunchObject : MonoBehaviour
{
    public Vector3 destination;
    public float speed = 5f;
    public GameObject clone;

    // Use this for initialization
    void Start()
    {
        destination = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            Transform clone = (Transform)GameObject.Instantiate(transform, transform.position, transform.rotation);
            Rigidbody gameObjectsRigidBody = clone.gameObject.AddComponent<Rigidbody>();
            gameObjectsRigidBody.useGravity = false;
            clone.gameObject.AddComponent<CapsuleCollider>();
            gameObjectsRigidBody.velocity = transform.TransformDirection(Vector3.forward * 50);
        }

    }

    void OnCollisionExit(Collision col)
    {
        if(!col.gameObject.name.Equals("nerd"))
        {
            Destroy(transform.gameObject);
        }
    }
}
