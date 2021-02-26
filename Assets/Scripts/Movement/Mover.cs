using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    public void moveRight() {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }

    public void moveLeft() {
        rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
    }

    public void StopMove() {
        rb.velocity = new Vector2(0, rb.velocity.y);
    }
}
