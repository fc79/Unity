using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsController : MonoBehaviour
{
    public float speed = 10f;
    private Vector2 startPosition;
    
    void Start()
    {
        startPosition = transform.position;
       

    }

   
    void Update()
    {
        
        transform.Translate(translation: Vector2.up * speed * Time.deltaTime);
        
    }
}
