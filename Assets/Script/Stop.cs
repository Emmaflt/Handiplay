using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public GameObject Player;
    private GameObject PlayerSpawn;
    public PlayerBehavior playerSpeed;


    void Start()
    {

    }

   public void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        
        if(collision.CompareTag("Player"))  
        {
            rb2D.velocity = Vector3.zero;
            return;
        }
    }

}