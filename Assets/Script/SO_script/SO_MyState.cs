using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new MyState", menuName = "MyState", order = 52)]
public class SO_MyState : ScriptableObject
{
    public string stateName;
    public SO_MyState[] transitions = new SO_MyState[5];
    public SO_MyEvent stateEvent;

    public SO_MyState ChangeState(string _stateName)    //Transit to _stateName
    {
        foreach (var state in transitions)
        {
            if (_stateName == state.stateName)
            {
                state.stateEvent.Trigger();
                return state;
            }
        }
        //error message
        Debug.Log("Unable to transit. Error: " + _stateName.ToString() +" is not in " + this.stateName.ToString() + " transitions!");   
        //return this state (keep old state)
        return this;
    }
}
