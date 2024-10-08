using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface LocomotionContext
{
    void SetStat(LocomotionState newState);
}

public interface LocomotionState
{
    void Jump(LocomotionContext contex);
    void Fall(LocomotionContext contex);
    void Land(LocomotionContext contex);
    void Crouch(LocomotionContext contex);
}

public class LocomotionStatePattern : MonoBehaviour, LocomotionContext
{
    LocomotionState currentState = new GroundState();

    public void Crouch(LocomotionContext contex)
        => currentState.Crouch(contex);
    public void Fall(LocomotionContext contex)
        => currentState.Fall(contex);
    public void Jump(LocomotionContext contex)
        => currentState.Jump(contex);
    public void Land(LocomotionContext contex)
        => currentState.Land(contex);
    void LocomotionContext.SetStat(LocomotionState newState)
        => currentState = newState;
}

public class GroundState : LocomotionState
{
    public void Crouch(LocomotionContext contex)
    {
        Debug.Log("Crouch"); 
        contex.SetStat(new CrouchState());
    }

    public void Fall(LocomotionContext contex)
    {
        contex.SetStat(new InAirState());
    }

    public void Jump(LocomotionContext contex)
    {
        Debug.Log("Jump");
        contex.SetStat(new InAirState());
    }

    public void Land(LocomotionContext contex)
    {
        
    }
}
public class InAirState : LocomotionState
{
    public void Crouch(LocomotionContext contex)
    {
        
    }

    public void Fall(LocomotionContext contex)
    {
       
    }

    public void Jump(LocomotionContext contex)
    {
        
    }

    public void Land(LocomotionContext contex)
    {
        contex.SetStat(new GroundState());
    }
}
public class CrouchState : LocomotionState
{
    public void Crouch(LocomotionContext contex)
    {
        Debug.Log("UnCrouch");
        contex.SetStat(new GroundState());
    }

    public void Fall(LocomotionContext contex)
    {
        contex.SetStat(new InAirState());
    }

    public void Jump(LocomotionContext contex)
    {
        contex.SetStat(new GroundState());
    }

    public void Land(LocomotionContext contex)
    {
        
    }
}