using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 4f; // velocidad
    public float speedJump = 15f; //velocidad de salto
    private Rigidbody playerb; // rigidbody cuerpo rigido que nos permite movimiento
    private Vector3 moveInput; // el input en 3D  
    // Start is called before the first frame update
    void Start()
    {
        playerb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); //movimiento horizontal
        float moveZ = Input.GetAxisRaw("Vertical"); //movimiento vertical
        moveInput = new Vector3(moveX, 0, moveZ); //asignandole donde va cada movimiento
        if (Input.GetKey("space") && playerb.velocity.y == 0)
        {
            playerb.AddForce(transform.up * speedJump);
            Debug.Log("Bien hecho");// para la consola
           } 
            bool jumpPressed = Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space);

        if (jumpPressed && Mathf.Abs(playerb.velocity.y) < 0.01f)
        {
            playerb.AddForce(Vector3.up * speedJump, ForceMode.Impulse);
            Debug.Log("Salto ejecutado");
        }
    }
    private void FixedUpdate()
    {
        playerb.MovePosition(playerb.position + moveInput.normalized * speed * Time.fixedDeltaTime);
        // moviminto fluido
    }
}