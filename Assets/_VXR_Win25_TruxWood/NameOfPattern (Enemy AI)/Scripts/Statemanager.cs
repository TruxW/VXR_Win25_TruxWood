using UnityEngine;

public class Statemanager : MonoBehaviour
{
    public State currentState;

    
    void Update()
    {
        RunStateMachine();
    }

    private void RunStateMachine()
    {
        State nextState = currentState?.RunCurrentState();

        if (nextState != null )
        {
            SwitchToTheNextState(nextState);
        }
    }

    private void SwitchToTheNextState(State nextstate)
    {
        currentState = nextstate;
    }
}
