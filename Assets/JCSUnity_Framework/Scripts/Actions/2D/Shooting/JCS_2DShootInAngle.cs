﻿/**
 * $File: JCS_2DShootInAngle.cs $
 * $Date: $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information $
 *		                Copyright (c) 2016 by Shen, Jen-Chieh $
 */
using UnityEngine;
using System.Collections;

namespace JCSUnity
{

    [RequireComponent(typeof(JCS_ShootAction))]
    public class JCS_2DShootInAngle 
        : MonoBehaviour
        , JCS_Action
    {

        //----------------------
        // Public Variables

        //----------------------
        // Private Variables
        private JCS_ShootAction mShootAction = null;

        [SerializeField] private float mMinDegree = 120;
        [SerializeField] private float mMaxDegree = 240;

        [Tooltip("Degree per bullet shoot.")]
        [SerializeField] private float mDegreePerShoot = 10;

        private float mDelayTimer = 0;

        //----------------------
        // Protected Variables

        //========================================
        //      setter / getter
        //------------------------------

        //========================================
        //      Unity's function
        //------------------------------
        private void Awake()
        {
            this.mShootAction = this.GetComponent<JCS_ShootAction>();
        }

        private void Update()
        {

        }

        //========================================
        //      Self-Define
        //------------------------------
        //----------------------
        // Public Functions

        //----------------------
        // Protected Functions

        //----------------------
        // Private Functions

    }
}
