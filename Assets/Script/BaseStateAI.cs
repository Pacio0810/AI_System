using System;

namespace Script
{
    [Serializable]
    public abstract class BaseStateAI
    {
        public State State;

        public event Action<AIStateType> OnChangeState;
    
        public virtual void EnterState(){}

        public virtual void UpdateState(){}

        public virtual void ExitState()
        {
        }

        public void ChangeState(AIStateType nextStateType)
        {
            OnChangeState?.Invoke(nextStateType);
        }
    }
}
