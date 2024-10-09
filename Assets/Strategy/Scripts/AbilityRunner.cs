using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityRunner : MonoBehaviour
{
    private IAbility _currentAbility = new FireAbility();

    public void UseAbility() 
        => _currentAbility.Use(gameObject);
    public void ChangeAbility(IAbility ability) 
        => _currentAbility = ability;
}
