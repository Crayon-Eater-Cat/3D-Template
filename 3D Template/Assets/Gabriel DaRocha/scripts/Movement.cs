using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    private Vector2 _moveAmount;
    public float movementSpeed;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.linearVelocity = new Vector3(_moveAmount.x, rb.linearVelocity.y, _moveAmount.y) * movementSpeed;


    }

    public void HandleMovement(InputAction.CallbackContext ctc)
    {
        Debug.Log(ctc.ReadValue<Vector3>());
    }

    public void HandleJump(InputAction.CallbackContext ctx)
    {
        rb.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }
}

