using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaLosLados : MonoBehaviour
{
    public GameObject[] waypoints;
    public float plataformSpeed = 2;
    private int waypointsIndex = 0;
    private int direction = 1; 

    void Update()
    {
        MovePlataform();
    }

    void MovePlataform()
    {
        if (Vector3.Distance(transform.position, waypoints[waypointsIndex].transform.position) < 0.1f)
        {
            waypointsIndex += direction;

            if (waypointsIndex >= waypoints.Length)
            {
                waypointsIndex = waypoints.Length - 2;
                direction = -1;
            }
            else if (waypointsIndex < 0)
            {
                waypointsIndex = 1;
                direction = 1;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointsIndex].transform.position,plataformSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}
