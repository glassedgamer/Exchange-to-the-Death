using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckoutWorld : MonoBehaviour
{
    [Header("Carts")]
    [SerializeField] GameObject cartPrefab;
    [SerializeField] Transform cartSpawn;
    
    [SerializeField] float timeBetweenCarts = 30f;


    [Header("Money")]
    [SerializeField] GameObject moneyPrefab;

    [SerializeField] float timeBetweenMoney;

    [SerializeField] int moneyAmount;

    void Start()
    {
        InvokeRepeating("CartAttack", timeBetweenCarts, timeBetweenCarts);
        InvokeRepeating("MoneyAttack", timeBetweenMoney, timeBetweenMoney);
    }

    void CartAttack()
    {
        Instantiate(cartPrefab, cartSpawn.position, Quaternion.identity);        
    }

    void MoneyAttack()
    {
        for (int i = 0; i < moneyAmount; i++)
        {
            var position = new Vector3(Random.Range(-8f, 8f), 4.5f, 0);
            Instantiate(moneyPrefab, position, Quaternion.identity);
        }
    }
}
