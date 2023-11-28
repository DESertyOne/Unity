using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SphereTrtggerGravity : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
          gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<Rigidbody>().useGravity=true;
    }
}
