using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarCollector : MonoBehaviour
{
    
    
    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Star"))
        {
            UIManager.instance.NextStar();
            Destroy(collision.gameObject);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spikes"))
        {

            Destroy(gameObject);
            UIManager.instance.Restart();
        }
    }

} 

