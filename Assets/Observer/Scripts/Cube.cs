using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] [Range(0,10)] private float JumpForce;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Player.instance.OnHit += CubeJump;
    }

    public void CubeJump()
    {
        rb.velocity = Vector3.up * JumpForce;
    }
}
