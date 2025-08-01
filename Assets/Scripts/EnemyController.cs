using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject puntoA;
    public GameObject puntoB;
    public Transform currentPoint;
    public EnemyStats enemyStats;
    public float life;
    public float damage;
    public float speed;

    public class EnemyStats
{
    public float MaxLife = 100f;
    public float Damage = 10f;
    public float Speed = 5f;
}

    void Awake()
    {
        life = enemyStats.MaxLife;
        damage = enemyStats.Damage;
        speed = enemyStats.Speed;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentPoint = puntoA.transform;
    }

    void Update()
    {
        
        Vector3 direction = currentPoint.position - transform.position;
        direction.y = 0; // para no subir o bajar

        direction.Normalize();

       
        rb.velocity = direction * speed;

       
        if (Vector3.Distance(transform.position, currentPoint.position) < 0.9f)
        {
            if (currentPoint == puntoB.transform)
            {
                currentPoint = puntoA.transform;
            }
            else if (currentPoint == puntoA.transform)
            {
                currentPoint = puntoB.transform;
            }
        }

        // Si se muere el enemigo
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(puntoA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(puntoB.transform.position, 0.5f);
        Gizmos.DrawLine(puntoA.transform.position, puntoB.transform.position);
    }
}
