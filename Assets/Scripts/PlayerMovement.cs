using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;

    public Camera playerCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // player movement
        if (Input.GetKey(KeyCode.W))
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.A))
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        if (Input.GetKey(KeyCode.S))
            transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.D))
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));

        // player rotation
        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(new Vector3(0, -rotateSpeed * Time.deltaTime, 0));
        if (Input.GetKey(KeyCode.E))
            transform.Rotate(new Vector3(0, rotateSpeed * Time.deltaTime, 0));
    }
}
