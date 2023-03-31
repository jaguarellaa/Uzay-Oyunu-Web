using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour
{
    
    public float speed = 2.5f;


    private void Start()
    {   
       
        Destroy(gameObject,15);
    }

  

    void FixedUpdate()
    { 
        
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}