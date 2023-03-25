using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour, IMovementable<float>
{
    public void Move(float speed)
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
