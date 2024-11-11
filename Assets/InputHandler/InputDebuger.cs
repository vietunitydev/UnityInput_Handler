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

    [SerializeField] private bool A;
    [SerializeField] private bool B;
    [SerializeField] private bool Y;
    [SerializeField] private bool X;
    [SerializeField] private bool L1;
    [SerializeField] private bool R1;
    [SerializeField] private bool L2;
    [SerializeField] private bool R2;

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
        for(int i=0;i<names.Length;i++){
            if(names[i] != String.Empty){
                playerNumber = i+1;
            }
        }

        text.text = bd.ToString();

        right_X = instance.GetAxisValue(GamepadAxis.RightHorizontal, playerNumber);
        right_Y = instance.GetAxisValue(GamepadAxis.RightVertical, playerNumber);
        
        left_X = instance.GetAxisValue(GamepadAxis.LeftHorizontal, playerNumber);
        left_Y = instance.GetAxisValue(GamepadAxis.LeftVertical, playerNumber);
        
        dpad_X = instance.GetAxisValue(GamepadAxis.DPADHorizontal, playerNumber);
        dpad_Y = instance.GetAxisValue(GamepadAxis.DPADVertical, playerNumber);

        A = instance.GetButton(GamepadButton.ActionSouth, playerNumber);
        B = instance.GetButton(GamepadButton.ActionEast, playerNumber);
        X = instance.GetButton(GamepadButton.ActionWest, playerNumber);
        Y = instance.GetButton(GamepadButton.ActionNorth, playerNumber);

        L1 = instance.GetButton(GamepadButton.LeftBumper, playerNumber);
        R1 = instance.GetButton(GamepadButton.RightBumper, playerNumber);
        // L2 = instance.GetButtonDown(GamepadButton.LeftStickButton, playerNumber);
        R2 = instance.GetButton(GamepadButton.RightStickButton, playerNumber);
    }
    
}

