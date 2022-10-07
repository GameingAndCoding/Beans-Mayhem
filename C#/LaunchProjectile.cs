using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LaunchProjectile : MonoBehaviour
{

    //Objects
    public Weapon Weapon;
    public GameObject Player;
    public float PowerValue = 0f;

 	public bool ShotTaken = false;


    //Linking
    public TurnSwitch TurnSwitch;
    public int PlayerNumber;
    public WeaponSwitching WeaponSwitching;
    public string[] WeaponNumbers;



    private void Update()
    {

        if (WeaponSwitching.CurrentWeapon == 1)
        {
            ChoseWeapon(WeaponNumbers[0]);
        }
        else if (WeaponSwitching.CurrentWeapon == 2)
        {
            ChoseWeapon(WeaponNumbers[1]);
        }
        else if (WeaponSwitching.CurrentWeapon == 3)
        {
            ChoseWeapon(WeaponNumbers[2]);
        }
        else if (WeaponSwitching.CurrentWeapon == 4)
        {
            ChoseWeapon(WeaponNumbers[3]);
        }

        if (ShotTaken == false && Input.GetMouseButtonDown(0) && TurnSwitch.CurrentPlayer == PlayerNumber && Input.GetMouseButton(1))
        {
            Weapon.shoot();
			ShotTaken = true;
        }

 			if (Input.GetKeyDown("n"))
       		{
            	ShotTaken = false;
       		 }

        PowerValue = Weapon.VelocityModifier;
    }

    private void ChoseWeapon(string weapon)
    {
        Weapon = GameObject.Find(weapon).GetComponent<Weapon>();
    }

}