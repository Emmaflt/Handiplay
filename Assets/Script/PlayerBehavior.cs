using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBehavior : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public int Speed = 25;

    Rigidbody2D m_rb2D;
    SpriteRenderer m_renderer;

void start(){
    GetComponent<Rigidbody2D>().AddForce(Vector2.right * Speed);
}
    void Awake()
    {
        m_rb2D = gameObject.GetComponent<Rigidbody2D>();
        m_renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void MovingRight()
    {
        float horizontalOffset = Input.GetAxis("Horizontal");
        float verticalOffset = Input.GetAxis("Vertical");
        if (Input.GetAxis("Horizontal") > 0f)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * Speed);
        }
    }
    public void MovingLeft()
    {
        if (Input.GetAxis("Horizontal") < 0f)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.left * Speed);
        }
    }
    public void MovingBottom()
    {
        if (Input.GetAxis("Vertical") < 0f)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.down* Speed);
        }
    }


    void FixedUpdate()
    {
        MovingRight();
        MovingLeft();
        MovingBottom();
    }
}
