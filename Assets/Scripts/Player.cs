using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    public float moveSpeed = 23.0f;

    private float inputValue;
    private Vector2 direction;
         
    void Update()
    {
        inputValue = Input.GetAxisRaw("Horizontal");

        if (inputValue == 1)
        {
            direction = Vector2.right;
        }
        else if (inputValue == -1)
        {
            direction = Vector2.left;
        }
        else
        {
            direction = Vector2.zero;
        }

        rigidBody2D.AddForce(direction * moveSpeed * Time.deltaTime * 100);

    }
}
