using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushball : MonoBehaviour
{

    void Start()
    {                
        GetComponent<Rigidbody>().AddForce(0,0,-10, ForceMode.Impulse);
    }

    void FixedUpdate()
    {

    }
}
