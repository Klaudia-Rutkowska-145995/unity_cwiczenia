using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 10.0f;
    //public float x = transform.position.x;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(speed, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
