using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayDecorator : MonoBehaviour, IAbility
{
    private IAbility WrapedAbility;

    public DelayDecorator(IAbility wrapedAbility)
    {
        WrapedAbility = wrapedAbility;
    }

    void IAbility.Use(GameObject gameObject)
    {
        // Delay Code
        WrapedAbility.Use(gameObject);
    }
}

