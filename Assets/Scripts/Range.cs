using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range : MonoBehaviour
{
    public GameObject pin;
    public GameObject range;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Candy"))
        {
            collision.gameObject.GetComponent<HingeJoint2D>().enabled = true;
            pin.GetComponent<HingeJoint2D>().enabled = true;
            pin.GetComponent<RopeSpawner>().enabled = true;
            range.SetActive(false);
        }
    }
}
