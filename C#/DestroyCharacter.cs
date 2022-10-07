using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCharacter : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.GetComponent<Collider>().gameObject);
    }
}
