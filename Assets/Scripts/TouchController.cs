using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{   
    public GameObject cursor;
    [Range(0.1f,1)] public float smoothness = 0.9f;

    private bool mouseDown;

    void Start()
    {
        cursor.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            mouseDown = true;
            cursor.SetActive(true);
        }
        else if (Input.GetMouseButtonDown(0))
        {
            mouseDown = false;
            cursor.SetActive(true);
        }

        if(mouseDown){
            var mousePosition = Input.mousePosition;
            var worldPosition = ScreenToWorldPoint(mousePosition);
            cursor.transform.position = Vector3.Lerp(cursor.transform.position, worldPosition, smoothness);
        }
    }

    Vector3 ScreenToWorldPoint(Vector3 screenPoint){
        var position = Camera.main.ScreenToWorldPoint(screenPoint);
        position.z = 0;

        return position;
    }
}
