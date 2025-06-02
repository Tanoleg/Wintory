using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;

    private Vector2 moveVector;

    private Rigidbody2D _rigidBody;

    void Awake() { 
    
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.y = Input.GetAxis("Vertical");
        _rigidBody.MovePosition(_rigidBody.position + moveVector * speed * Time.deltaTime);
    }
}
