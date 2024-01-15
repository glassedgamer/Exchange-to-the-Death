using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public Transform player;

    public bool isFlipped = false;

    GameObject checkoutWorldManager;

    void Start()
    {
        checkoutWorldManager = GameObject.FindWithTag("CheckoutWorldManager");

        InvokeRepeating("CartAttack", checkoutWorldManager.timeBetweenMoney, checkoutWorldManager.timeBetweenMoney);
    }

    void Update()
    {
        LookAtPlayer();
    }

    void LookAtPlayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;

        if (transform.position.x > player.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = false;
        }
        else if (transform.position.x < player.position.x && !isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = true;
        }
    }

    void Stage1Attack()
    {
        checkoutWorldManager.GetComponent<CheckoutWorld>().MoneyAttack();
    }

}
