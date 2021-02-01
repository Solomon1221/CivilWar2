using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour
{
    Camera cam;

    private void Start()
    {
        cam = FindObjectOfType<Camera>();
    }
    private void Update()
    {


        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x - 1, transform.position.y, -10);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + 1, transform.position.y, -10);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1, -10);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, -10);
        }
        if (Input.GetKey(KeyCode.UpArrow))
            cam.orthographicSize -= .1f;
        if (Input.GetKey(KeyCode.DownArrow))
            cam.orthographicSize += .1f;
    }
}
