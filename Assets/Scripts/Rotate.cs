using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
   
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0f, 0f, 180f)*Time.deltaTime);
    }
}
