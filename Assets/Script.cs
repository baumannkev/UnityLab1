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
            cube.transform.Rotate(0.5f, 0.0f, 0.5f);
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
            Vector3 y = new Vector3(0, 0, 1.0f);
            //cube.transform.position += new Vector3(0, 0, 1);
            cube.transform.position += y;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 y = new Vector3(0, 0, -1.0f);
            //cube.transform.position += new Vector3(0, 0, -1);
            cube.transform.position += y;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 x = new Vector3(1.0f, 0, 0);
            //cube.transform.position += new Vector3(0, 1, 0);
            cube.transform.position += x;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 x = new Vector3(-1.0f, 0, 0);
            //cube.transform.position += new Vector3(0, -1, 0);
            cube.transform.position += x;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 y = new Vector3( 0, 1.0f, 0);
            //cube.transform.position += new Vector3(0, 1, 0);
            cube.transform.position += y;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 y = new Vector3(0, -1.0f,  0);
            //cube.transform.position += new Vector3(0, 1, 0);
            cube.transform.position += y;
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
