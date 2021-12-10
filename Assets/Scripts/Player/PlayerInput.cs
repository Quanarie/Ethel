using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : IInput
{
    [SerializeField] private Joystick joystick;

    public event Action OnInteractButtonPressed = delegate { };
    public event Action OnInteractButtonUnpressed = delegate { };
    public event Action OnWeaponButtonPressed = delegate { };

    private void FixedUpdate()
    {
        Vertical = joystick.Vertical;
        Horizontal = joystick.Horizontal;
    }

    public void InteractPressed() => OnInteractButtonPressed();
    public void InteractUnpressed() => OnInteractButtonUnpressed();
    public void WeaponPressed() => OnWeaponButtonPressed();
}
