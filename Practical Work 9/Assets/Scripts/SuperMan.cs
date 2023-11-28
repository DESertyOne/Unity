using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperMan : MonoBehaviour
{
    [SerializeField] Transform _Enemy;
    private Transform _EnemyTarget;
    void Start()
    {
        _EnemyTarget = _Enemy;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(20,0,0, ForceMode.Impulse) ;
        transform.position = Vector3.MoveTowards(transform.position, _EnemyTarget.position, Time.deltaTime) ;
    }
}
