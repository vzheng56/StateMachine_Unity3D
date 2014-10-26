using UnityEngine;
using System.Collections;
using StateNameSpace;

public class StateManager : MonoBehaviour {

    private IStateBase _activeState;
   // private 
	// Use this for initialization
	void Start () {

        _activeState = new BeginState(this);

	}
	
	// Update is called once per frame
	void Update () {
        if (_activeState != null)
            _activeState.StateUpdate();
	}

    void OnGUI()
    {
        if (_activeState != null)
            _activeState.ShowState();
    }

    public void SwitchState(IStateBase baseState)
    {
        _activeState = baseState;
    }
}
