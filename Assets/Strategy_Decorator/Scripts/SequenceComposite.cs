using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceComposite : MonoBehaviour, IAbility
{
    private IAbility[] abilities;

    public SequenceComposite(IAbility[] abilities)
    {
        this.abilities = abilities;
    }

    void IAbility.Use(GameObject gameObject)
    {
        foreach (var ability in abilities) 
        {
            ability.Use(gameObject);
        }
    }
}
