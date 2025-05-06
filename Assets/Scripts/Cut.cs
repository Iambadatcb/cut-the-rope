using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Rope")){

        var joint = collision.gameObject.GetComponent<Joint2D>();
        if(joint!=null) Destroy(joint);
        }
    }
}
