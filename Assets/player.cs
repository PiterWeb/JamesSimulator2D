using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private double initVelocity = 0.05;
    private Vector2 maxVelocity = new(15, 0);
    private new Rigidbody2D rigidbody2D;
    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame

    // Generate velocity in base of the rigidbody2d variable

    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow)) {
            sprite.flipX = false;

            if (rigidbody2D.velocity.Equals(maxVelocity * -1)) return;

            rigidbody2D.velocity += new Vector2((float)(initVelocity * -1), 0);
        }

        if (Input.GetKey(KeyCode.RightArrow)) {

            if (rigidbody2D.velocity.Equals(maxVelocity)) return;

            rigidbody2D.velocity += new Vector2((float)initVelocity, 0);
            sprite.flipX = true;
        }

        // if (Input.GetKey(KeyCode.UpArrow)) {
        //     rigidbody2D.velocity
        // }

    }
}
