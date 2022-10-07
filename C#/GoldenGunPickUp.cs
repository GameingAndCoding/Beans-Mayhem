using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenGunPickUp : MonoBehaviour
{
    private SavedAmmo SavedAmmo;
    private GameObject Player;
    [SerializeField] private GameObject self;
    
    private void OnTriggerEnter(Collider other)
    {
        Player = other.GetComponent<Collider>().gameObject;
        SavedAmmo = Player.GetComponent<SavedAmmo>(); 
        SavedAmmo.Ammo[3] =2;
        Destroy(self);
    }
    
    
    
    
}
