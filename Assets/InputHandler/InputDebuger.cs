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

    private void Update()
    {
        right_X = instance.GetAxisValue(GamepadAxis.RightHorizontal, 1);
        right_Y = instance.GetAxisValue(GamepadAxis.RightVertical, 1);
        
        left_X = instance.GetAxisValue(GamepadAxis.LeftHorizontal, 1);
        left_Y = instance.GetAxisValue(GamepadAxis.LeftVertical, 1);
    }
}
