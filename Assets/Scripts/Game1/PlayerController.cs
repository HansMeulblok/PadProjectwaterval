using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Vector2 usingSpeed;
    public float movement;
    private float moving;
    public float shoot;
    private Rigidbody2D rigid;
    Vector3 velocity;
    public GameObject Bullet;
    Vector2 bulletPos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;



    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float shoot = Input.GetAxis("Fire1");
        float moveHorizontal = Input.GetAxis("Horizontal");
        movement = 0;
        if (shoot > 0 && Time.time > nextFire) {
            nextFire = Time.time + fireRate;
            Fire();
        }
        if (moveHorizontal > 0)
        {
                movement = 1f;
        }
        else if (moveHorizontal < 0)
        {
            movement = -1f;
        }
        Vector3 targetVelocity = new Vector2(movement * speed, 0);
        rigid.velocity = targetVelocity;
    }
    void Fire()
    {
        bulletPos = transform.position;
        Instantiate(Bullet, bulletPos, Quaternion.identity);
    }
}
