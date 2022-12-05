using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // The Target
    public Transform target;
    // Update is called once per frame
    void Start()
    {
      
    }
    void fixUpdate()
    {
      Vector3 targetPos = new Vector3(target.position.x,
                                         transform.position.y,
                                         transform.position.z);
        transform.position = targetPos;
    }
}
