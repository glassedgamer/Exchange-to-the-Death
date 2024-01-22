using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{

    [SerializeField] PlayerHealth playerHealth;

    [SerializeField] int healthPickupVal = 20;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Damageable")
        {
            print("AHHHHHHHH");
            playerHealth.TakeDamage(10);
            Destroy(col.gameObject);
        } else if(col.gameObject.tag == "HealthPickup") 
        {
            print("Health");
            playerHealth.GainHealth(healthPickupVal);
            Destroy(col.gameObject);
        }
    } 
}
