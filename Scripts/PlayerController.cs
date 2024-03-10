using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        // move forward
        transform.Translate(Vector3.forward * Time.deltaTime * 20 );
    }
}
