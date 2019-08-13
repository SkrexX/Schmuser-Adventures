using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MieserMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public int speed = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        controller.Move(speed * Time.fixedDeltaTime, false, false);
    }

    public void CaveMoves()
    {
        //while(true)
        //controller.Move(0, false, true);
    }
}
