
using UnityEngine;

namespace Script
{
    public class IdleState : BaseStateAI
    {
        public IdleState()
        {
            State = AIManager.Instance.IdleConfig;
        }

        public override void EnterState()
        {
            
        }

        public override void UpdateState()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                ChangeState(AIStateType.Patrol);
            }
        }

        public override void ExitState()
        {
        }
    }
}
