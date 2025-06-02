using UnityEngine;
using UnityEngine.UIElements;

public class HandRotating : MonoBehaviour
{
    private float _offset;
    private float _angleZ;
    private Vector3 _diference;
    private Vector3 _localScale;

    private void Update()
    {
        Rotate();

        _localScale = Vector3.one;

        Flip();

        transform.localScale = _localScale;
    }
    private void Rotate()
    {
        _diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        _angleZ = Mathf.Atan2(_diference.y, _diference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, _angleZ + _offset);
    }
    private void Flip()
    {
        if (_angleZ > 90 || _angleZ < -90)
        {
            _localScale.y = -1f;
        }
        else
        {
            _localScale.y = 1f;
        }
    }
}
