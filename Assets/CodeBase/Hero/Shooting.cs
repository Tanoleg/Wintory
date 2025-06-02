using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Transform _firePoint;
    [SerializeField] private int _damage = 10;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    
    private void Shoot()
    {
        Debug.DrawRay(_firePoint.position, _firePoint.right, Color.green);
        RaycastHit2D hitInfo = Physics2D.Raycast(_firePoint.position, _firePoint.right);


        if (hitInfo)
        {
            Debug.Log(hitInfo.transform.name);
            Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(_damage);
            }
        }

    }
}
