using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    public float speed = 20;

    void Update()
    {
        // move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed );
    }
}
