using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaSubeBaja3D : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody rb;
    public GameObject puntoA;
    public GameObject puntoB;
    public Transform currentPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentPoint = puntoA.transform;

    }

    void Update()
    {
        Vector3 direction = currentPoint.position - transform.position;

        if (currentPoint == puntoA.transform)
        {
            rb.velocity = new Vector3(0, speed, 0); // sube
        }
        else
        {
            rb.velocity = new Vector3(0, -speed, 0); // baja
        }

        if (Vector3.Distance(transform.position, currentPoint.position) < 0.9f && currentPoint == puntoB.transform)
        {
            currentPoint = puntoA.transform;
        }
        else if (Vector3.Distance(transform.position, currentPoint.position) < 0.9f && currentPoint == puntoA.transform)
        {
            currentPoint = puntoB.transform;
        }
    }

    private void OnDrawGizmos()
    {
        if (puntoA != null && puntoB != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(puntoA.transform.position, 0.5f);
            Gizmos.DrawWireSphere(puntoB.transform.position, 0.5f);
            Gizmos.DrawLine(puntoA.transform.position, puntoB.transform.position);
        }
    }
}
