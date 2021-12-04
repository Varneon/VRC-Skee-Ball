﻿
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;

namespace Pyralix.SkeeBall
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class BallBlockerReset : UdonSharpBehaviour
    {
        [SerializeField] private SkeeballMain SkeeballMain;

        private int _ballCount;
        
        private void OnTriggerExit(Collider other)
        {
            _ballCount++;
            if (Networking.IsOwner(gameObject))
            {
                SkeeballMain._IncrementBlockCount();
            }
        }

    }
}
