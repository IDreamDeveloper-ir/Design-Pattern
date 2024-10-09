using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAbility : MonoBehaviour, IAbility
{
    void IAbility.Use(GameObject gameObject)
    {
        Debug.Log("Fire Magic");
    }
}
