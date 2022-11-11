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

    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
        Debug.Log(speed);

        //direction = Random.Range(-1, 2);
        InvokeRepeating("ThrowAnApple", 10f, 10f);
    }

    float randomSpeed()
    {
        speed = Random.Range(3.0f, 10.0f);
        return speed;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Random.value < changeRotation)
        {
            randomSpeed();
            speed *= -1;
        }
    }

    void ThrowAnApple()
    {
        time += Time.deltaTime;
        int clock = (int)time;
        //Debug.Log(clock);
        //Debug.Log("Throw apple");
        //Debug.Log(Time.time);
    }
}
