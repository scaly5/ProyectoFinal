using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 4f; // velocidad
    public float speedJump = 15f; // velocidad de salto
    private Rigidbody playerb; // cuerpo rigido
    private Vector3 moveInput; // el input en 3D  

    void Start()
    {
        playerb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); // movimiento horizontal
        float moveZ = Input.GetAxisRaw("Vertical"); // movimiento vertical
        moveInput = new Vector3(moveX, 0, moveZ); // asignando el movimiento

     
        if (Input.GetMouseButtonDown(0) && Mathf.Abs(playerb.velocity.y) < 0.01f)
        {
            playerb.AddForce(Vector3.up * speedJump, ForceMode.Impulse);
            Debug.Log("Salto ejecutado");
        }
    }

    void FixedUpdate()
    {
        playerb.MovePosition(playerb.position + moveInput.normalized * speed * Time.fixedDeltaTime);
    }
}

