using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class InputDebuger : MonoBehaviour
{
    private InputHandler instance => InputHandler.Instance;

    [SerializeField] private float right_X;
    [SerializeField] private float right_Y;
    [SerializeField] private float left_X;
    [SerializeField] private float left_Y;
    [SerializeField] private float dpad_X;
    [SerializeField] private float dpad_Y;

    [SerializeField] private int playerNumber;
    [SerializeField] Text text;
    [SerializeField] string[] names;


    private void Update()
    {
        StringBuilder bd = new StringBuilder();
        names = Input.GetJoystickNames();
        foreach(var name in names){
            bd.AppendLine("- " + name);
        }

        text.text = bd.ToString();

        right_X = instance.GetAxisValue(GamepadAxis.RightHorizontal, playerNumber);
        right_Y = instance.GetAxisValue(GamepadAxis.RightVertical, playerNumber);
        
        left_X = instance.GetAxisValue(GamepadAxis.LeftHorizontal, playerNumber);
        left_Y = instance.GetAxisValue(GamepadAxis.LeftVertical, playerNumber);
        
        dpad_X = instance.GetAxisValue(GamepadAxis.LeftHorizontal, playerNumber);
        dpad_Y = instance.GetAxisValue(GamepadAxis.LeftVertical, playerNumber);
    }
    
}

