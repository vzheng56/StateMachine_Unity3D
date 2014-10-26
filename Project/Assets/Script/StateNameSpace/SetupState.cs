using UnityEngine;
using System.Collections;

namespace StateNameSpace
{
    public class SetupState:IStateBase
    {
        private StateManager _stateMgr;

        public SetupState(StateManager stateManager)
        {
            _stateMgr = stateManager;
        }

        public void StateUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //切换状态
                _stateMgr.SwitchState(new PlayState1(_stateMgr));
            }
        }

        public void ShowState()
        {
            Debug.Log("在 SetupState 状态中");
        }
    }
}