using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public GameObject cube;
    public Vector3 rvect = Vector3.one;
    public float speed = 1.0f;

    private bool isRotating;
    // Start is called before the first frame update
    void Start()
    {
        isRotating = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (isRotating)
        {
            cube.transform.Rotate(0.5f, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isRotating) { 
                isRotating = false;
            } else {
                isRotating = true;
            }

        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            cube.transform.Translate(0, 0, 0.5f);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            cube.transform.Translate(0, 0, -0.5f);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            cube.transform.Translate(0.5f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            cube.transform.Translate(-0.5f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            cube.transform.Translate(0, 0.5f, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            cube.transform.Translate(0, -0.5f, 0);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            cube.GetComponent<Renderer>().material.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            cube.GetComponent<Renderer>().material.color = Color.green;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            cube.GetComponent<Renderer>().material.color = Color.blue;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            cube.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
