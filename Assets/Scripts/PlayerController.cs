using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movimiento del jugador")]
    public float speed = 4f; // Velocidad de movimiento
    public float speedJump = 15f; // Velocidad de salto

    private Rigidbody playerb; // Cuerpo rigido
    private Vector3 moveInput; // Input de movimiento en 3D

    [Header("Camara y raton")]
    public Camera cam;
    [Tooltip("Sensibilidad horizontal del raton")]
    public float mouseSensitivityX = 3.0f;
    [Tooltip("Sensibilidad vertical del raton")]
    public float mouseSensitivityY = 2.0f;
    public float minRotation = -65.0f;
    public float maxRotation = 60.0f;

    private float h_mouse, v_mouse;

    [Header("Vida del jugador")]
    public float Life = 100f;
    public float MaxLife = 100f;

    void Start()
    {
        playerb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        moveInput = new Vector3(moveX, 0, moveZ); // Movimiento con teclado

       
        h_mouse = mouseSensitivityX * Input.GetAxis("Mouse X");
        v_mouse += mouseSensitivityY * Input.GetAxis("Mouse Y");
        v_mouse = Mathf.Clamp(v_mouse, minRotation, maxRotation);

        cam.transform.localEulerAngles = new Vector3(-v_mouse, 0, 0);
        transform.Rotate(0, h_mouse, 0);  // Movimiento con raton

       
        if (Input.GetMouseButtonDown(0) && Mathf.Abs(playerb.velocity.y) < 0.01f)
        {
            playerb.AddForce(Vector3.up * speedJump, ForceMode.Impulse);
            Debug.Log("Salto ejecutado");  // Salto
        }
    }

    void FixedUpdate()
    {
        Vector3 direction = new Vector3(moveInput.x, 0, moveInput.z);

        if (direction.magnitude > 1)
            direction.Normalize();

        Vector3 moveDir = transform.TransformDirection(direction);
        playerb.MovePosition(playerb.position + moveDir * speed * Time.fixedDeltaTime);
    }
}

