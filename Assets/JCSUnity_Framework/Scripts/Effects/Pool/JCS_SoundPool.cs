﻿/**
 * $File: JCS_SoundPool.cs $
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

    /// <summary>
    /// Pool of sound
    /// </summary>
    public class JCS_SoundPool
        : MonoBehaviour
    {

        //----------------------
        // Public Variables

        //----------------------
        // Private Variables
        [Header("** Runtime Variables **")]
        [Tooltip("Pool of the audio clips")]
        [SerializeField]
        private AudioClip[] mAudioClips = null;
        [Tooltip("Sound Type u want to organize")]
        [SerializeField]
        private JCS_SoundSettingType mSoundSettingType = JCS_SoundSettingType.NONE;

        //----------------------
        // Protected Variables

        //========================================
        //      setter / getter
        //------------------------------

        //========================================
        //      Unity's function
        //------------------------------

        //========================================
        //      Self-Define
        //------------------------------
        //----------------------
        // Public Functions
        public AudioClip GetRandomSound()
        {
            int randIndex = JCS_UsefualFunctions.JCS_IntRange(0, mAudioClips.Length);

            return mAudioClips[randIndex];
        }

        //----------------------
        // Protected Functions

        //----------------------
        // Private Functions

    }
}
