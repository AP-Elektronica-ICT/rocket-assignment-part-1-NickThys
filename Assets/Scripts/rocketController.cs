using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketController : MonoBehaviour
{
    public float speed=30f;
    public float Rspeed = 1f;
    private float distToGround;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space")) {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        
        if (Input.GetKey("right"))
        {
            transform.Rotate(Vector3.right* Rspeed);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(Vector3.left * Rspeed);

        }

    }
  
}
