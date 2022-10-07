using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{

    public TurnSwitch TurnSwitch;
    public Camera cam;
    public Camera FPSCam;
    [SerializeField] 
    private int PlayerNumber;
    [SerializeField]
    private GameObject UI;

    void Update()
    {

        if (TurnSwitch.CurrentPlayer == PlayerNumber)
        {
            cam.depth = 1;
            UI.SetActive(true);
        }
        else
        {
            cam.depth = 0;
        }
        if (TurnSwitch.CurrentPlayer == PlayerNumber && Input.GetMouseButton(1))
        {
            FPSCam.depth = 2;
        }
        else
        {
            FPSCam.depth = 0;
        }





    }

    void OnDisable()
    {
        TurnSwitch.CurrentPlayer++;
    }
}
