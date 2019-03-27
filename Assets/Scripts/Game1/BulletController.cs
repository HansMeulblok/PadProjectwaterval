using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    float velX;
    public float velY;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rb.position);
        rb.velocity = new Vector3(0,velY,0);
        if (rb.position.y >= 20)
            Destroy(gameObject);
    }
}
