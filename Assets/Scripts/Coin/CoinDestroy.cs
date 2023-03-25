using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroy : MonoBehaviour, IDestroyable
{
    public void DestroyObject()
    {
        Destroy(gameObject);
    }

    public void DestroyObjectWithTime()
    {
        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
