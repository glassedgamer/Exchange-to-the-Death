using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] Animator animator;

    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bulletPrefab;

    public void Shoot(InputAction.CallbackContext context)
    {
        if(context.started)
            Shoot();
    }

    void Shoot()
    {
        animator.SetTrigger("Shoot");
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
