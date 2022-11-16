using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyApple : MonoBehaviour
{
    public GameObject applePrefab;
    int score = 0;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "PlayerFloor" || other.gameObject.name == "Player/Basket")
        {
            Debug.Log("Kolizja wykryta");
            Destroy(applePrefab);
        }
        if(other.gameObject.name == "Player/Basket")
        {
            CountScore.score++;
        }
        if (other.gameObject.name == "PlayerFloor")
        {
            Uncaught.uncaughtApples++;
        }
    }

}
