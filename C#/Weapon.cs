using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public WeaponData WeaponData;
    [SerializeField] private string ShootpointName;
    [SerializeField] private string PlayerNumber;
    public Transform LaunchPoint;
    public GameObject projectile;
    private GameObject Launched;
    [SerializeField] int WeaponID;

    public SavedAmmo SavedAmmo;

    [SerializeField] private Transform filler;
    
    //Arch
    public float VelocityModifier;



    void Awake()
    {
        LaunchPoint = GameObject.Find(ShootpointName).GetComponent<Transform>();
        SavedAmmo = GameObject.Find(PlayerNumber).GetComponent<SavedAmmo>();

        WeaponData.CurrentAmmo = SavedAmmo.Ammo[WeaponID];

        if (LaunchPoint = null)
        {
            LaunchPoint = filler;
            SavedAmmo = filler.GetComponent<SavedAmmo>();
        }
    }

    void Update()
    {

        VelocityModifier += Input.GetAxis("Mouse ScrollWheel");
        VelocityModifier = Mathf.Clamp(VelocityModifier, 1f, 2.5f);
    }


    public void shoot()
    {
        if (WeaponData.CurrentAmmo>0) {
            LaunchPoint = GameObject.Find(ShootpointName).GetComponentInChildren<Transform>();
            Debug.Log("test");
            Launched = Instantiate(projectile, LaunchPoint, false);
            Launched.transform.parent = null;

           

           
           Launched.GetComponent<Rigidbody>().AddRelativeForce(0, LaunchPoint.rotation.x, WeaponData.velocity * VelocityModifier);


            WeaponData.CurrentAmmo--;
            SavedAmmo.Ammo[WeaponID]--;
            
            
            //legacy projectile launching
            //Launched.GetComponent<Rigidbody>().AddForce(-transform.forward * WeaponData.velocity);
            //Launched.GetComponent<Rigidbody>().AddForce(transform.up * LaunchPoint.rotation.x);
        }
    }

}
