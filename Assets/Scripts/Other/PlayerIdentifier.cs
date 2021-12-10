using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdentifier : MonoBehaviour
{
    public static PlayerIdentifier Instance;

    [HideInInspector] public GameObject Player;

    private void Start()
    {
        Instance = this;
        Player = this.gameObject;
    }
}
