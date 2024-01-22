using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : MonoBehaviour
{

    // public int increaseHealthValue = 20;

    [SerializeField] float speed = 10f;
    [SerializeField] Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.up * -speed;
    }
}
