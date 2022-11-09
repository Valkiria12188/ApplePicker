using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour
{
    public Rigidbody rb;
    float speed;
    public float x = 100;

    public float time;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        speed = Random.Range(1, 8);
        InvokeRepeating("ThrowAnApple", 10f, 10f);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = Vector3.right * speed;
    }

    void ThrowAnApple()
    {
        time += Time.deltaTime;
        int clock = (int)time;
        //Debug.Log(clock);
        Debug.Log("Throw apple");
        Debug.Log(Time.time);
    }
}
