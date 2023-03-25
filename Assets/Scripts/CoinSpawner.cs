using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private float repeatRate = 1;
    [SerializeField] private float height = 5;
    [SerializeField] private GameObject coin;
    private float timer = 0;
    
    void Update()
    {
        Timer();
    }

    private void Timer()
    {
        if (timer > repeatRate)
        {
            timer = 0;
            SpawnCoin();
        }

        timer += Time.deltaTime;
    }

    private void SpawnCoin()
    {
        GameObject newCoin = Instantiate(coin);
        newCoin.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }
}
