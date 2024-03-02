using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRB : MonoBehaviour
{
    public float speed = .1f;
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDiriection = new Vector3(xDirection, 0.0f, zDirection);

        transform.position += moveDiriection * speed;
    }


}//MoveRB
