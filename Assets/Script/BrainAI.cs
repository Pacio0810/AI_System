using UnityEngine;

namespace Script
{
    public enum AIStateType
    {
        Idle,
        Patrol,
        Alerted,
        Chase,
        Attack
    }

    public class BrainAI : MonoBehaviour
    {
        private BaseStateAI initialState;
        private BaseStateAI currentState;

        private PatrolState patrolState;
        private IdleState idleState;
        private AlertedState alertedState;
    
        void Start()
        {
            InitState();
            initialState = idleState;
            TransitionToNewState(initialState);
        }

        void InitState()
        {
            idleState = new IdleState();
            patrolState = new PatrolState();
            alertedState = new AlertedState();
        }

        void Update()
        {
            currentState?.UpdateState();
        }

        void TransitionToNewState(BaseStateAI newState)
        {
            currentState?.ExitState();

            currentState = newState;
            currentState.OnChangeState += HandleChangeRequest;
        
            currentState?.EnterState();
        }

        void HandleChangeRequest(AIStateType newAIType)
        {
            BaseStateAI nextState = null;
            switch (newAIType)
            {
                case AIStateType.Idle:
                    nextState = idleState;
                    break;
                case AIStateType.Patrol:
                    nextState = patrolState;
                    break;
                case AIStateType.Alerted:
                    nextState = alertedState;
                    break;
            }

            if (nextState != null)
            {
                TransitionToNewState(nextState);
            }
        }
    }
}