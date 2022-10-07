using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{


    public GameObject Bazooka;
    public GameObject Granade;
    public GameObject pistol;
    public GameObject Golden;
    public Transform Position;
    public int CurrentWeapon;

    public TurnSwitch TurnSwitch;
    [SerializeField]
    private int PlayerNumber;


    private GameObject B, G, P, GP;

    void Update()
    {

        if (TurnSwitch.CurrentPlayer == PlayerNumber)
        {
            if (Input.GetKeyDown("1") && B == null)
            {
                B = Instantiate(Bazooka, Position, false);
                Destroy(G);
                Destroy(P);
                Destroy(GP);
                CurrentWeapon = 1;
            }
            else if (Input.GetKeyDown("2") && G == null)
            {
                G = Instantiate(Granade, Position, false);
                Destroy(B);
                Destroy(P);
                Destroy(GP);
                CurrentWeapon = 2;
            }
            else if (Input.GetKeyDown("3") && P == null)
            {
                P = Instantiate(pistol, Position, false);
                Destroy(B);
                Destroy(G);
                Destroy(GP);
                CurrentWeapon = 3;
            }
            else if (Input.GetKeyDown("4") && GP == null)
            {
                GP = Instantiate(Golden, Position, false);
                Destroy(B);
                Destroy(G);
                Destroy(P);
                CurrentWeapon = 4;
            }
        }
    }
}
