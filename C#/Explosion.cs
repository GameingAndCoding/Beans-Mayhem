using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private int ID;
    [SerializeField] private HealthSystem HealthSystem;
    [SerializeField] private int Damage;

    [SerializeField] private GameObject Self;

    private void Start()
    {
        HealthSystem = GameObject.Find("GameManager").GetComponent<HealthSystem>();
        Destroy(Self);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        ID = other.GetComponent<movement>().PlayerNumber;

      HealthSystem.health[ID] -= Damage;

      

    }
    
    
}
