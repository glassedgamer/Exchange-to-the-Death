using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Damageable")
        {
            print("AHHHHHHHH");
            Destroy(col.gameObject);
        }
    } 
}
