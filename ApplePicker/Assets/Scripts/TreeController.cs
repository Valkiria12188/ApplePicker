using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour
{
    public Rigidbody rb;
    float speed = 2.0f;
    int direction = 0;
    public float time;
    float changeRotation = 0.02f; //szansa na zmianê rotacji w trakcie jednego z kierunków przed osi¹gnieciem krawêdzi
    float leftCorner = -8.0f;
    float rightCorner = 8.0f;

    [Header("Apple Settings")]
    public GameObject applePrefab;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("ThrowAnApple", 3f, 1f);
    }
    void Update()
    {
        Vector3 position = transform.position;
        position.x += speed * Time.deltaTime;
        transform.position = position;

        if (position.x < leftCorner)
        {
            randomSpeed();
            speed = Mathf.Abs(speed);
        }
        else if (position.x > rightCorner)
        {
            randomSpeed();
            speed = -Mathf.Abs(speed);
        }

      
    }

    private void FixedUpdate()
    {
        if (Random.value < changeRotation)
        {
            randomSpeed();
            speed *= -1;
        }
    }
    float randomSpeed()
    {
        speed = Random.Range(3.0f, 10.0f);
        return speed;
    }
    void ThrowAnApple()
    {
        Vector3 applePosition = transform.position;
        applePosition.y = 1.4f;
        
        GameObject clone = Instantiate(applePrefab, applePosition, Quaternion.identity);
        Destroy(clone, 4f);
    }
}
