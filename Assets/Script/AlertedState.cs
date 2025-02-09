using UnityEngine;

namespace Script
{
    public class AlertedState : BaseStateAI
    {
        public AlertedState()
        {
            State = AIManager.Instance.AlertedConfig;
        }

        public override void EnterState()
        {

        }

        public override void UpdateState()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                ChangeState(AIStateType.Idle);
            }
        }

        public override void ExitState()
        {
        }
    }
}
