using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 4f; // velocidad
    public float speedJump = 15f; // velocidad de salto
    private Rigidbody playerb; // cuerpo rigido
    private Vector3 moveInput; // el input en 3D  

    public Camera cam;
    public float mouseHorizontal = 3.0f;
    public float mouseVertical = 2.0f;
    public float minRotation = -65.0f;
    public float maxRotation = 60.0f;
    float h_mouse, v_mouse;

    private Vector3 move = Vector3.zero;
    public float Life = 100f;
    public float MaxLife = 100f;

    void Start()
    {
        playerb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); // movimiento horizontal
        float moveZ = Input.GetAxisRaw("Vertical"); // movimiento vertical
        moveInput = new Vector3(moveX, 0, moveZ); // asignando el movimiento
        h_mouse = mouseHorizontal * Input.GetAxis("Mouse X"); //movimiento raton
        v_mouse += mouseVertical * Input.GetAxis("Mouse Y"); //movimiento raton
        v_mouse = Mathf.Clamp(v_mouse, minRotation, maxRotation);//movimiento raton
        cam.transform.localEulerAngles = new Vector3(-v_mouse, 0, 0);//movimiento raton
        transform.Rotate(0, h_mouse, 0);

        if (Input.GetMouseButtonDown(0) && Mathf.Abs(playerb.velocity.y) < 0.01f)
        {
            playerb.AddForce(Vector3.up * speedJump, ForceMode.Impulse);
            Debug.Log("Salto ejecutado");
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

