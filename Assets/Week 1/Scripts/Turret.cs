using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    float speed = 35f;

    void Update()
    {
        float keyboardInput = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, keyboardInput * speed * Time.deltaTime);
    }
}