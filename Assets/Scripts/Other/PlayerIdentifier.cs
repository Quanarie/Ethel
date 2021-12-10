using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdentifier : MonoBehaviour
{
    public static PlayerIdentifier Instance;

    private void Start()
    {
        Instance = this;
    }
}
