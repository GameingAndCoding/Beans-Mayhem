using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private Transform platform;
    private void OnTriggerEnter(Collider other)
    {

        other.GetComponent<Collider>().gameObject.transform.parent = platform;

    }
    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Collider>().gameObject.transform.parent = null;
    }
    
}
