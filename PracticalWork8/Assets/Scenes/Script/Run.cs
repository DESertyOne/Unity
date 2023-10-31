using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Run : MonoBehaviour
{
    public float speed = 0.1f;
    public Transform[] pointone;
    public int moveingTo = 0;
    public int movementDerection = 1;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (pointone == null || pointone.Length < 1)
        {
            return;
        }
        while(true) 
        {
          transform.position = Vector3.MoveTowards(transform.position, pointone[pointone.Length+1].position,Time.deltaTime * speed);

        }

    }
}
