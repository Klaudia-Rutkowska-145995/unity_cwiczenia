using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        transform.Rotate(0, 90, 0, Space.Self);
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
        transform.Rotate(0, 90, 0, Space.Self);
        transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        transform.Rotate(0, 90, 0, Space.Self);
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
        transform.Rotate(0, 90, 0, Space.Self);
    }
}
