using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaLados3D : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;
    public GameObject puntoC;
    public GameObject puntoD;
    public Transform currentPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentPoint = puntoC.transform;
        rb.useGravity = false;
    }

    void Update()
    {
        Vector3 direction = currentPoint.position - transform.position;

        if (currentPoint == puntoC.transform)
        {
            rb.velocity = new Vector3(0, 0, speed); // Adelante
        }
        else
        {
            rb.velocity = new Vector3(0, 0, -speed); // AtrAS
        }

        if (Vector3.Distance(transform.position, currentPoint.position) < 0.9f && currentPoint == puntoD.transform)
        {
            currentPoint = puntoC.transform;
        }
        else if (Vector3.Distance(transform.position, currentPoint.position) < 0.9f && currentPoint == puntoC.transform)
        {
            currentPoint = puntoD.transform;
        }
    }
}
