/**
 * $File: JCS_DeactivePanelButton.cs $
 * $Date: 2017-09-04 16:37:26 $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information 
 *	                 Copyright (c) 2017 by Shen, Jen-Chieh $
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JCSUnity
{
    /// <summary>
    /// Deactive panel button.
    /// </summary>
    public class JCS_DeactivePanelButton
        : JCS_Button
    {
        /* Variables */

        [Header("** Runtime Variables (JCS_DeactivePanelButton) **")]

        [Tooltip("Play dialogue sound?")]
        [SerializeField]
        private bool mHideWithSound = true;

        [Tooltip("Panels to be deactive.")]
        [SerializeField]
        private JCS_DialogueObject[] mDialogueObjects = null;

        [Tooltip("Tween Panels to be deactive.")]
        [SerializeField]
        private JCS_TweenPanel[] mTweenPanels = null;


        /* Setter & Getter */

        public bool HideithSound { get { return this.mHideWithSound; } set { this.mHideWithSound = value; } }


        /* Functions */

        public override void JCS_OnClickCallback()
        {
            foreach (JCS_DialogueObject panel in mDialogueObjects)
            {
                if (panel != null)
                {
                    if (mHideWithSound)
                        panel.HideDialogue();
                    else
                        panel.HideDialogueWithoutSound();
                }
            }

            foreach (JCS_TweenPanel panel in mTweenPanels)
            {
                if (panel != null)
                    panel.Deactive();
            }
        }
    }
}
