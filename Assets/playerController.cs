using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public bool isGrounded;

    public Rigidbody bodyForUse;

    public float moveX;
    public float moveY;

    public float movementSpeed;
    public float jumpForce;
    public bool jumpInput;

    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        Vector3 camForward = Camera.main.transform.forward;
        camForward.y = 0;
        Quaternion camRot = Quaternion.LookRotation(camForward);



        Vector3 clampedInput = new Vector3(moveX, 0, moveY);
        clampedInput = camRot * clampedInput;
        clampedInput = Vector3.ClampMagnitude(clampedInput, 1);

        moveX = clampedInput.x;
        moveY = clampedInput.z;

        jumpInput = Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.JoystickButton0);
        if (jumpInput)
        {
            jumpInput = false;
            if (isGrounded)
            {
                bodyForUse.AddForce(0, jumpForce, 0, ForceMode.VelocityChange);
            }
        }
    }
    public void FixedUpdate()
    {

        Vector3 newVelocity = new Vector3();
        newVelocity = bodyForUse.velocity;
        newVelocity.x = moveX * Time.deltaTime * movementSpeed;
        newVelocity.z = moveY * Time.deltaTime * movementSpeed;

        bodyForUse.velocity = newVelocity;

        Vector3 newRotation = new Vector3(newVelocity.x, 0, newVelocity.z);
        if (newRotation.magnitude > 0.5f)
        {
            transform.forward = Vector3.RotateTowards(transform.forward, newRotation, Time.deltaTime * rotationSpeed, 0);
        }
    }
}
