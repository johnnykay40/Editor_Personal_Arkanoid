using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;

    public float speed = 30;

    private Vector2 velocity; 

    void Start()
    {
        velocity.x = Random.Range(-1f, 1f);

        velocity.y = 1f;

        rigidBody2D.AddForce(velocity * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BottomWall"))
        {
            FindObjectOfType<GameManager>().LoseHealth();
        }
    }
    void Update()
    {
        
    }
}
