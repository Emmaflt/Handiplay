using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopStickClone : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public GameObject StickClone;
    public StickPlusClone StickSpeed2;

    public int Speed = 10;
    Rigidbody2D m_rb2D;

    Rigidbody2D m_rb2D2;
    SpriteRenderer m_renderer;

    public bool departPlayer;

    public GameObject Player;
    void oui()
    {
        StickSpeed2.Speed = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        departPlayer = false;
        
        if(collision.CompareTag("Stick") || collision.CompareTag("PrefabStick"))  
        {
           /* m_rb2D2.velocity = Vector2.zero;*/
            StickSpeed2.Speed = 0;
            oui();
            Debug.Log("Saucisse");
            departPlayer = true;
            
        }
        if(departPlayer == true){
        Player.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 150);
        departPlayer = false;
        StickSpeed2.enabled = true;
        }

        
    }

    }
