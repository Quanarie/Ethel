using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IMoveDirection : MonoBehaviour
{
    public float Vertical { get; protected set; }
    public float Horizontal { get; protected set; }
}
