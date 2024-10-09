using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterAbility : MonoBehaviour, IAbility
{
    void IAbility.Use(GameObject gameObject)
    {
        Debug.Log("Water Magic");
    }
}

