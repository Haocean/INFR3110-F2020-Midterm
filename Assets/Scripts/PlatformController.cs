using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;

    public float speed;
    public bool forward;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(forward == true)
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        else
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));

        if(pointA.transform.position.x < transform.position.x && forward == true)
            forward = !forward;
        else if(pointB.transform.position.x > transform.position.x && forward == false)
            forward = !forward;


    }
}
