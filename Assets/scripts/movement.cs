using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyJoystick;

public class movement : MonoBehaviour
{
    
    [SerializeField] private float Speed ;
    [SerializeField] private  Joystick joystick;
    

    void Update()
    {

        float xmovement = joystick.Horizontal();
        float zmovement = joystick.Vertical();
        //transform.position += new Vector3(xmovement,0f, zmovement)* Speed *Time.deltaTime;
        transform.Translate(new Vector3(xmovement, 0f, zmovement) * Speed * Time.deltaTime);
        

        
    }
}