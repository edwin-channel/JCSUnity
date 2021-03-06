﻿/**
 * $File: JCS_DestroyObjectWithTime.cs $
 * $Date: $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information 
 *                   Copyright (c) 2016 by Shen, Jen-Chieh $
 */
using UnityEngine;
using System.Collections;

namespace JCSUnity
{
    /// <summary>
    /// Destroy the gameobject by time.
    /// </summary>
    [RequireComponent(typeof(JCS_FadeObject))]
    public class JCS_DestroyObjectWithTime
        : MonoBehaviour
    {
        /* Variables */

        [Header("** Runtime Variables (JCS_DestroyObjectWithTime) **")]

        [Tooltip("Target time to destroy.")]
        [SerializeField] [Range(0.0f, 3600.0f)]
        private float mDestroyTime = 10.0f;

        private float mTimer = 0;
        private bool mTimesUp = false;

        [Tooltip("While destroying, fade out the gameobject.")]
        [SerializeField]
        private bool mDestroyWithAlphaEffect = true;

        private JCS_FadeObject mFadeObject = null;


        /* Setter & Getter */

        public JCS_FadeObject GetFadeObject() { return this.mFadeObject; }
        public float DestroyTime { get { return this.mDestroyTime; } set { this.mDestroyTime = value; } }
        public bool TimesUp { get { return this.mTimesUp; } set { this.mTimesUp = value; } }


        /* Functions */

        private void Awake()
        {
            this.mFadeObject = this.GetComponent<JCS_FadeObject>();
        }

        private void Update()
        {
            mTimer += Time.deltaTime;

            if (mDestroyWithAlphaEffect)
            {
                if (mDestroyTime - mTimer <= mFadeObject.FadeTime)
                    mFadeObject.FadeOut();
            }

            if (mDestroyTime < mTimer)
            {
                TimesUp = true;
                Destroy(this.gameObject);
            }
        }
    }
}
