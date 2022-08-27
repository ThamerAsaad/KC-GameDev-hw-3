using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float Move;
    public float Speed;
    Rigidbody2D RB;
    public Transform GroundCheck;
    public float rad;
    public LayerMask groundLayer;
    bool isgrounded;

    public float JumpSped = 8f;
    float direction = 0f;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isgrounded = Physics2D.OverlapCircle(GroundCheck.position, rad, groundLayer);
        Move = Input.GetAxisRaw("Horizontal");
        RB.velocity = new Vector2 (Move * Speed , RB.velocity.y);
        if (Input.GetButtonDown("Jump") && isgrounded)
        {
            RB.velocity = new Vector2 (RB.velocity.x, JumpSped);
        }
    }
}
