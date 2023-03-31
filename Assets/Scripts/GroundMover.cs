using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMover : MonoBehaviour
{

    public float speed;
    float groundLength;

    BoxCollider2D groundcollider;

    private void Start()
    {
        groundcollider = GetComponent<BoxCollider2D>();
        groundLength = groundcollider.size.x;
    }


    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

        if(transform.position.x<=-groundLength)
        {
            transform.position = new Vector2(transform.position.x + 2*groundLength, transform.position.y);
        }
    }
}
