using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    float acceleration;
    float steering;
    public float forwardSpeed = 500;
    public float steeringSpeed = 200;
    public Transform booster;
    Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        acceleration = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        rigidbody.AddTorque(steering * -steeringSpeed * Time.deltaTime);
        Vector2 force = transform.up * acceleration * forwardSpeed * Time.deltaTime;
        rigidbody.AddForce(force);
    }

    private void OnTriggerEnter2D(Collider2D booster)
    {
            Vector2 boost = transform.up * acceleration * forwardSpeed * 100 * Time.deltaTime;
            rigidbody.AddForce(boost);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        rigidbody.AddTorque(steering * -steeringSpeed * Time.deltaTime);
        Vector2 force = transform.up * acceleration * forwardSpeed * Time.deltaTime;
        rigidbody.AddForce(force);
    }


}
