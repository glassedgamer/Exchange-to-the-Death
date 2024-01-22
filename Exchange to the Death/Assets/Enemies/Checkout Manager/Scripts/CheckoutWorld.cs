using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CheckoutWorld : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] Text countDown;

    WaitForSeconds countDownTimerVal;

    [Header("Carts")]
    [SerializeField] GameObject cartPrefab;
    [SerializeField] Transform cartSpawn;
    
    [SerializeField] float timeBetweenCarts = 30f;

    [Header("Money")]
    [SerializeField] GameObject[] moneyPrefab;

    [SerializeField] int moneyAmount;

    public float timeBetweenMoney;

    [Header("Health Pickups")]
    [SerializeField] GameObject healthPickup;

    [SerializeField] float timeBetweenHealth = 30f;


    void Start()
    {

        /*InvokeRepeating("CartAttack", timeBetweenCarts, timeBetweenCarts);
        InvokeRepeating("MoneyAttack", timeBetweenMoney, timeBetweenMoney);*/
        countDownTimerVal = new WaitForSeconds(1f);
        StartCoroutine(IntroTimer());

        InvokeRepeating("DropHealth", timeBetweenHealth + 3, timeBetweenHealth);
    }

    public void CartAttack()
    {
        Instantiate(cartPrefab, cartSpawn.position, Quaternion.identity);        
    }

    public void MoneyAttack()
    {
        for (int i = 0; i < moneyAmount; i++)
        {
            var position = new Vector3(Random.Range(-8f, 8f), 4.5f, 0);
            var randomMoney = Random.Range(0, 2);

            GameObject clone = Instantiate(moneyPrefab[randomMoney], position, Quaternion.identity);
        }
    }

    void DropHealth() 
    {
        var position = new Vector3(Random.Range(-8f, 8f), 4.5f, 0);

        Instantiate(healthPickup, position, Quaternion.identity);
    }

    IEnumerator IntroTimer()
    {
        for (int i = 3; i >= 0; i--)
        {
            countDown.text = i.ToString();

            if (i == 0)
            {
                countDown.text = "GO";
                yield return countDownTimerVal;
                countDown.gameObject.SetActive(false);
            }

            yield return countDownTimerVal;

        }
    }
}
