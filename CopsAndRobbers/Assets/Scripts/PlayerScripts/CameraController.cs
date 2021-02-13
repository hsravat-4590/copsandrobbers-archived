﻿using System;
using Cinemachine;
using Mirror;
using UnityEngine;

namespace Me.DerangedSenators.CopsAndRobbers
{
    /// <summary>
    /// Camera Controller script
    /// </summary>
    public class CameraController : NetworkBehaviour
    {

        public CinemachineVirtualCamera mVirtualCamera;
        public Transform playerPrefab;
        private void Start()
        {
            mVirtualCamera = GetComponent<CinemachineVirtualCamera>();
        }

        public override void OnStartLocalPlayer()
        {
            if (IsLocalPlayer)
            {
                mVirtualCamera.m_Follow = playerPrefab;
            }
        }
        
    }
}