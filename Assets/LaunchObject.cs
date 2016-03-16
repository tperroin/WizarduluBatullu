using UnityEngine;
using System.Collections;

public class LaunchObject : MonoBehaviour
{

    public Rigidbody spawnObject;
    private float throwPower;
    public Vector3 destination;
    public float speed = 5f;

    // Use this for initialization
    void Start()
    {
        spawnObject = GetComponent<Rigidbody>();
        destination = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            GameObject clone;
            clone = Instantiate(spawnObject.transform, spawnObject.transform.position, spawnObject.transform.rotation) as GameObject;

            float x = spawnObject.transform.position.x;
            float y = spawnObject.transform.position.y;
            float z = spawnObject.transform.position.z;
            transform.position = Vector3.Lerp(
                new Vector3(x, y, z), 
                new Vector3(x, y, z * 100), 
                speed);
        }

    }

    void OnCollisionExit(Collision col)
    {
       // Destroy(col.gameObject);
    }
}
