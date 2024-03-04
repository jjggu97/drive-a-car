using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public int moveSpeed;
    public float move;
    public float moveVertical;

    public int rotSpeed;
    public float rotate;
    public float rotHorizon;

    public float rotTurret;
    public GameObject turret;

    void Start()
    {
        moveSpeed = 5;
        rotSpeed = 120;
    }

    void Update()
    {
        move = moveSpeed * Time.deltaTime;
        rotate = rotSpeed * Time.deltaTime;

        moveVertical = Input.GetAxis("Vertical");
        rotHorizon = Input.GetAxis("Horizontal");
        rotTurret = Input.GetAxis("Window Shake X");

        transform.Translate(Vector3.forward * move * moveVertical);
        transform.Translate(new Vector3(0.0f, rotate * rotHorizon, 0.0f));
        turret.transform.Rotate(Vector3.up * rotTurret * rotate);
    }
}
