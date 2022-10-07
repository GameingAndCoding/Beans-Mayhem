using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private GameObject Prefab;
    [SerializeField] private GameObject self;
    [SerializeField] private Transform contact;
    
    [SerializeField] private WeaponData WeaponData;
    
    //New spawn and new object to spawn
    private Vector3 SpawnHere;
    private GameObject Explosion;
    
    
    private void OnTriggerEnter(Collider other)
    {
           StartCoroutine(ExecuteAfterTime(WeaponData.delay));
    }
    
    
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        
        SpawnHere = new Vector3(contact.position.x,contact.position.y,contact.position.z);
        Explosion = Instantiate(Prefab,SpawnHere,Quaternion.identity);
        Destroy(self);
    }
}
