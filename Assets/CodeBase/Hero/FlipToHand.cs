using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipToHand : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    private SpriteRenderer _spriteRenderer;
    private Vector3 _position;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        _position = _camera.WorldToScreenPoint(transform.position);
        Flip();
    }

    private void Flip()
    {
        if(Input.mousePosition.x < _position.x)
        {
            _spriteRenderer.flipX = true;
        }
        if(Input.mousePosition.x > _position.x)
        {
            _spriteRenderer.flipX = false;
        }
    }
}
