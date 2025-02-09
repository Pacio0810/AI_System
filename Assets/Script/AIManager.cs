using System;
using UnityEngine;

namespace Script
{
    public class AIManager : MonoBehaviour
    {
        public State PatrolConfig;
        public State IdleConfig; 
        public State AlertedConfig;
        
        public static AIManager Instance { get; private set; }

        private void Awake()
        {
            if (Instance!= null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(transform.parent.gameObject);
        }
    }
}
