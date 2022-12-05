using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroll : MonoBehaviour
{
    public float speed = 4f;
    private Vector2 startPosition;
   
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation: Vector2.up * speed * Time.deltaTime);
        if(transform.position.y > 182.2f)
        {
            transform.position = startPosition;
        }
    }
}
