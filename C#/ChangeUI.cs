using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeUI : MonoBehaviour
{


    [SerializeField] private  GameObject Htxt;
    [SerializeField] private  GameObject Atxt;
    [SerializeField] private  HealthSystem HealthSystem;
    [SerializeField] private TurnSwitch TurnSwitch;
    [SerializeField] private  GameObject[] bean;
    [SerializeField] private  Slider SliderP, SliderM;
    [SerializeField] private  LaunchProjectile launchProjectile;
    [SerializeField] private  movement movement;


    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 4; i++)
        {
            if (TurnSwitch.CurrentPlayer == i)
            {
                Htxt.GetComponent<UnityEngine.UI.Text>().text = HealthSystem.health[i].ToString();
                launchProjectile = bean[i].GetComponent<LaunchProjectile>();
				movement = bean[i].GetComponent<movement>();
                SliderP.value = launchProjectile.PowerValue;
				SliderM.value = movement.Counter;
                Atxt.GetComponent<UnityEngine.UI.Text>().text = launchProjectile.Weapon.WeaponData.CurrentAmmo.ToString();
            }
        }


    }
}