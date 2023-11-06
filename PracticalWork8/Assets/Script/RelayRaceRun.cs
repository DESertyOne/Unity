using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelayRaceRun : MonoBehaviour
{
    public Transform[] athlete;
    public float Speed;
    private Transform nextTargetTransform;
    private float passDistance = 0.1f;
    private int indexTarget;
    private bool nextAthlete;
    private Vector3 target;
    public bool movement;

    void Start()
    {
        indexTarget = 0;       
        nextTargetTransform.SetParent(athlete[indexTarget]);
        target = athlete[indexTarget].position;

    }

    void Update()
    {
        if (movement)
        {
            transform.LookAt(nextTargetTransform);
            transform.position = Vector3.MoveTowards(transform.position, target, Speed * Time.deltaTime);
        }

    }
    public void NextAthlete()
    { 
        if(nextAthlete)
        {
            if(indexTarget < athlete.Length-1)
            {
                if(transform.position == athlete[indexTarget].position)
                {
                    indexTarget++;
                    target = athlete[indexTarget].position;
                    nextTargetTransform.SetParent(athlete[indexTarget] );
                }
                //else if (  )
                //{

                //}
            }
        }
    }
    
}
