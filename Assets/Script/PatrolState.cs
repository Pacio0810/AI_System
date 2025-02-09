using UnityEngine;

namespace Script
{
    public class PatrolState : BaseStateAI
    {
        public PatrolState()
        {
            State = AIManager.Instance.PatrolConfig;
        }

        public override void EnterState()
        {
        }

        public override void UpdateState()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                ChangeState(AIStateType.Alerted);
            }
        }

        public override void ExitState()
        {
            
        }
    }
}
