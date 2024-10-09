using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirAbility : MonoBehaviour, IAbility
{
    void IAbility.Use(GameObject gameObject)
    {
        Debug.Log("Air Magic");
    }
}

