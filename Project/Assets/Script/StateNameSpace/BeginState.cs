using UnityEngine;
using System.Collections;

namespace StateNameSpace
{
    public class BeginState:IStateBase
    {
        private StateManager _stateManagerRef;
        //构造函数 完成初始化功能——将 StateManager 传入
        public  BeginState(StateManager stateMgr)
        {
            _stateManagerRef = stateMgr;
        }

        public void StateUpdate()
        {
            Debug.Log(this + "维持中....");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //切换状态
                _stateManagerRef.SwitchState(new SetupState(_stateManagerRef));
            }
        }

        public void ShowState()
        {

        }

    }
}