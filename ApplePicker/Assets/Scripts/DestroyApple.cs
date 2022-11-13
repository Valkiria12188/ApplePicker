using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyApple : MonoBehaviour
{
    public GameObject applePrefab;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "PlayerFloor" || other.gameObject.name == "Player/Basket")
        {
            Debug.Log("Kolizja wykryta");
            Destroy(applePrefab);
        }
    }
}
