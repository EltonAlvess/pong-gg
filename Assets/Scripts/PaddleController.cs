using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 5f;
    public string axis = "Horizontal";
    public Rigidbody2D rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        float v = Input.GetAxisRaw(axis);
        rb.velocity = new Vector2(v, 0) * speed;
    }
}
