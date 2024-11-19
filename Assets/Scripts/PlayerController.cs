using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    private readonly float speed = 20.0f;
    private readonly float xRange = 20.0f;

    public GameObject projecticlePrefab;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <-xRange)
        {
            transform.position = new UnityEngine.Vector3(-xRange,transform.position.y,transform.position.z);
        }

        else if(transform.position.x > xRange)
        {
            transform.position = new UnityEngine.Vector3(xRange,transform.position.y,transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projecticlePrefab,transform.position,projecticlePrefab.transform.rotation);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(UnityEngine.Vector3.right*horizontalInput*Time.deltaTime*speed);
    }
}
