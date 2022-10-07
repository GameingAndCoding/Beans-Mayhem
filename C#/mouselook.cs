using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    public Vector2 turn;
    private float sensitivity = .5f;
    private Vector3 deltaMove;
    public TurnSwitch TurnSwitch;
    [SerializeField] 
    private int PlayerNumber;
    public GameObject Fpscamera;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {

        if (TurnSwitch.CurrentPlayer == PlayerNumber)
        {
            turn.x += Input.GetAxis("Mouse X") * sensitivity;
            turn.y = Input.GetAxis("Mouse Y") * sensitivity;
            transform.localRotation = Quaternion.Euler(0, turn.x, 0);
            Fpscamera.transform.Rotate(-turn.y, 0, 0);
        }

    }
}
