using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CoinMovement))]
public class Coin : MonoBehaviour, ICollectable
{
    [SerializeField] private float speed;
    [SerializeField] private CoinMovement _coinMovement;
    [SerializeField] private CoinDestroy _coinDestroy;
    
    void Update()
    {
        _coinMovement.Move(speed);
        _coinDestroy.DestroyObjectWithTime();
    }

    public void GetPoints()
    {
        GameManager.Instance.points++;
        _coinDestroy.DestroyObject();
    }
}
