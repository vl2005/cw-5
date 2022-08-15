using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padel : MonoBehaviour
{
    Rigidbody2D RB;
    float playerInput;
    public float speed;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        playerInput = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(playerInput * speed, 0);
    }
}
