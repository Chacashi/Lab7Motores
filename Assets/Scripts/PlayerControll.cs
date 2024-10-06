using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControll : MonoBehaviour
{
    Rigidbody _compRigidbody;
    [SerializeField] float speed;
    private void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector3(horizontal*speed,_compRigidbody.velocity.y, vertical * speed );
    }
    float horizontal;
    float vertical;
    public void Horizontal(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<float>();
    }

    public void Vertical (InputAction.CallbackContext context)
    {
        vertical = context.ReadValue<float>();
    }
}
