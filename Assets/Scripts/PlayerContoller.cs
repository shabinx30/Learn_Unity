using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerContoller : MonoBehaviour
{
    // Movement tuning (editable in the inspector)
    public float speed = 5.0f;
    public float turnSpeed;

    // Input action exposed in inspector for input binding
    public InputAction moveAction;
    private Vector2 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // enable input based movement
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // Read the 2D vector from the MoveAction (x,y)
        moveInput = moveAction.ReadValue<Vector2>();
        // move vehicle in forward & backward direction
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        // vehicle rotaion using moveInput
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * moveInput.x);
    }
}
