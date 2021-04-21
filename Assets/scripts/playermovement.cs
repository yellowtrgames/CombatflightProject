using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public float movementspeed = 0f;
    Vector2 movement = new Vector2();
    Rigidbody2D rb2D;


    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movecharacter();
    }

    private void movecharacter()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.Normalize();
        rb2D.velocity = movement * movementspeed;
    }
}
