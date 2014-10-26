using UnityEngine;
using System.Collections;

namespace StateNameSpace
{
    public class WinStateScene1:IStateBase
    {

        private StateManager _stateMgr;

        public WinStateScene1(StateManager stateManager)
        {
            _stateMgr = stateManager;
        }

        public void StateUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //切换状态
                _stateMgr.SwitchState(new BeginState(_stateMgr));
            }
        }

        public void ShowState()
        {
            Debug.Log("在 WinStateScene1 状态中");
        }
    }
}