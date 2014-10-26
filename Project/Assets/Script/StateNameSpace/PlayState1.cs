using UnityEngine;
using System.Collections;

namespace StateNameSpace
{
    public class PlayState1:IStateBase
    {
        private StateManager _stateMgr;

        public PlayState1(StateManager stateMnager)
        {
            _stateMgr = stateMnager;
        }

        public void StateUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //切换状态
                _stateMgr.SwitchState(new WinStateScene1(_stateMgr));
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                _stateMgr.SwitchState(new LostStateScene1(_stateMgr));
            }
        }

        public void ShowState()
        {
            Debug.Log("在 PlayState1 状态中");
        }
    }
}