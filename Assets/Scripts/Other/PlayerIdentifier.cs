using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdentifier : MonoBehaviour
{
    public static PlayerIdentifier Instance;

    public PlayerHealth playerHealth;

    private void Start()
    {
        Instance = this;

        playerHealth = GetComponent<PlayerHealth>();
    }
}
