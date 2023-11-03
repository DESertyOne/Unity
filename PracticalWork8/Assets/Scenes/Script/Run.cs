using System;
using UnityEngine;

public class Run : MonoBehaviour
{
    public float speed;
    public Transform[] pointone;
    public bool movementDerection;
    private Vector3 target ;
    private int indexTarget = 0;
    

    void Start()
    {
        target = Transform[indexTarget].position;
    }

    void Update()
    {            
        transform.Rotate(0, 0, 0.2f);
        transform.LookAt(target);
        if (movementDerection)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        }
        if (transform.position == pointone[0].position)
        {                    
            target = pointone[1].position;
        }
        if (transform.position == pointone[1].position)
        {
            target = pointone[2].position;
        }

    }
}
