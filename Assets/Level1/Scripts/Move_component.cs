using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_component : MonoBehaviour
{
    public float Speed= 1.0f;
    public float JumpSpeed = 8.0f;
    
    
    private float mouseX;
    private float mouseY;
    public float rotateSpeed = 1.0f;
    private Transform playerCamera;

    private Rigidbody rb;
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        //Cursor.lockState = CursorLockMode.Locked;
        playerCamera = GetComponentInChildren<Camera>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        Camerarotate();
        Move();
    }

    void Move()
    {
 
        Vector2 direction = new Vector2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
        transform.localPosition += transform.forward* direction.x * Speed;
        transform.localPosition += transform.right* direction.y * Speed;
        

    }
    void Camerarotate()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * rotateSpeed, 0);

        playerCamera.Rotate(Input.GetAxis("Mouse Y") * rotateSpeed, 0, 0);
        if (playerCamera.localRotation.eulerAngles.y != 0)
        {
            playerCamera.Rotate(Input.GetAxis("Mouse Y") * rotateSpeed, 0, 0);
        }
    }
}
