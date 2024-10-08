using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocomotionPlayer : MonoBehaviour
{
    [SerializeField][Range(0, 10)] private float playerSpeed;
    [SerializeField][Range(0, 10)] private float playerJump;

    private LocomotionStatePattern _myLocomotion;
    private Rigidbody _rigidbody;
    private Vector2 _movmentAxis;
    

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _myLocomotion = gameObject.AddComponent<LocomotionStatePattern>();
    }

    private void movement(Vector2 direction)
    {
        _rigidbody.velocity = ((Vector3.right *  direction.x) 
            + (Vector3.forward * direction.y)) * playerSpeed 
            + (Vector3.up * _rigidbody.velocity.y);
    }

    private void Jump()
    {
        _rigidbody.velocity += (Vector3.up * playerJump);
        _myLocomotion.Jump(_myLocomotion);
    }

    private void Crouch()
    {
        _myLocomotion.Crouch(_myLocomotion);
    }

    private void Update()
    {
        _movmentAxis = Vector2.zero;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Crouch();
        }
        
        _movmentAxis.x = Input.GetAxis("Horizontal");
        _movmentAxis.y = Input.GetAxis("Vertical");

        if (_movmentAxis != Vector2.zero)
            movement(_movmentAxis);  
    }

    private void OnCollisionEnter(Collision other)
    {
        _myLocomotion.Land(_myLocomotion);
    }
}
