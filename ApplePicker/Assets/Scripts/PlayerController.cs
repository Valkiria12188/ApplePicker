using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 0f;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /* void Update()
     {
         float horizontal = Input.GetAxis("Horizontal");

         Vector3 movement = new Vector3(horizontal,0f,0f);
         rb.AddForce(movement*speed);
     }*/
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        rb.velocity = new Vector3(horizontal, 0f, 0f);
    }
}
