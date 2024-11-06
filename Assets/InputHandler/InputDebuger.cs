using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private void Update()
    {
        right_X = instance.GetAxisValue(GamepadAxis.RightHorizontal, playerNumber);
        right_Y = instance.GetAxisValue(GamepadAxis.RightVertical, playerNumber);
        
        left_X = instance.GetAxisValue(GamepadAxis.LeftHorizontal, playerNumber);
        left_Y = instance.GetAxisValue(GamepadAxis.LeftVertical, playerNumber);
        
        dpad_X = instance.GetAxisValue(GamepadAxis.LeftHorizontal, playerNumber);
        dpad_Y = instance.GetAxisValue(GamepadAxis.LeftVertical, playerNumber);
        
        var ActionEast = instance.GetButton(GamepadButton.ActionEast, playerNumber);
        var ActionNorth = instance.GetButton(GamepadButton.ActionNorth, playerNumber);
        var ActionWest = instance.GetButton(GamepadButton.ActionWest, playerNumber);
        var ActionSouth = instance.GetButton(GamepadButton.ActionSouth, playerNumber);

        var x = instance.GetButton(GamepadButton.Start, playerNumber);
        var y = instance.GetButton(GamepadButton.BackSelect, playerNumber);

        Debug.Log($"x {x} == y {y} ");
        Debug.Log($"ActionEast {ActionEast} == ActionNorth {ActionNorth} == ActionWest {ActionWest} == ActionNorth {ActionNorth} ");
        
        
    }
}
