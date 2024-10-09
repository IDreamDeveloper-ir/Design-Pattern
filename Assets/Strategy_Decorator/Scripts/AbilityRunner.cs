using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityRunner : MonoBehaviour
{
    //private IAbility _currentAbility = 
    //    new DelayDecorator(new FireAbility());

    private IAbility _currentAbility =
        new SequenceComposite(
            new IAbility[]
            {
                new FireAbility(),
                new WaterAbility(),
                new AirAbility(),
                new DelayDecorator(new FireAbility())
            });

    public void UseAbility() 
        => _currentAbility?.Use(gameObject);
    public void ChangeAbility(IAbility ability) 
        => _currentAbility = new DelayDecorator(ability);
}
