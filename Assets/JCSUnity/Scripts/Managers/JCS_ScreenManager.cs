/**
 * $File: JCS_ScreenManager.cs $
 * $Date: 2018-09-12 02:50:44 $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information
 *	                 Copyright © 2018 by Shen, Jen-Chieh $
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JCSUnity
{
    /// <summary>
    /// Manages screen action.
    /// </summary>
    public class JCS_ScreenManager
        : JCS_Managers<JCS_ScreenManager>
    {
        /* Variables */

        [Header("** Initialize Variables (JCS_ScreenManager) **")]

        [Tooltip("Resize screen once on this scene?")]
        public bool RESIZE_SCREEN_THIS_SCENE = false;

        [Tooltip("Aspect ratio screen width for this scene you want to resize.")]
        public int ASPECT_RATION_SCREEN_WIDTH_THIS_SCENE = 16;

        [Tooltip("Aspect ratio screen height for this scene you want to resize.")]
        public int ASPECT_RATION_SCREEN_HEIGHT_THIS_SCENE = 9;


        [Header("** Runtime Variables (JCS_ScreenManager) **")]

        [Tooltip("Type of the screen handle.")]
        public JCS_ScreenType SCREEN_TYPE_THIS_SCENE = JCS_ScreenType.RESIZABLE;


        [Header("** Check Variables (JCS_ScreenManager) **")]

        [Tooltip("Invisible object area.")]
        [SerializeField]
        private string mResizableScreenPanelPath = "JCSUnity_Resources/GUI/JCS_ResizableScreenPanel";

        [Tooltip("Top resizable screen panel.")]
        [SerializeField]
        private JCS_ResizableScreenPanel mTopASP = null;

        [Tooltip("Bottom resizable screen panel.")]
        [SerializeField]
        private JCS_ResizableScreenPanel mBottomASP = null;

        [Tooltip("Left resizable screen panel.")]
        [SerializeField]
        private JCS_ResizableScreenPanel mLeftASP = null;

        [Tooltip("Right resizable screen panel.")]
        [SerializeField]
        private JCS_ResizableScreenPanel mRightASP = null;


        /* Setter & Getter */

        public JCS_ResizableScreenPanel TopASP { get { return this.mTopASP; } }
        public JCS_ResizableScreenPanel BottomASP { get { return this.mBottomASP; } }
        public JCS_ResizableScreenPanel LeftASP { get { return this.mLeftASP; } }
        public JCS_ResizableScreenPanel RightASP { get { return this.mRightASP; } }


        /* Functions */

        private void Awake()
        {
            instance = this;

            // Spawn the four aspect screen panels.
            this.mTopASP = JCS_Utility.SpawnGameObject(mResizableScreenPanelPath).GetComponent<JCS_ResizableScreenPanel>();
            this.mBottomASP = JCS_Utility.SpawnGameObject(mResizableScreenPanelPath).GetComponent<JCS_ResizableScreenPanel>();
            this.mLeftASP = JCS_Utility.SpawnGameObject(mResizableScreenPanelPath).GetComponent<JCS_ResizableScreenPanel>();
            this.mRightASP = JCS_Utility.SpawnGameObject(mResizableScreenPanelPath).GetComponent<JCS_ResizableScreenPanel>();

            // Set the ASP direction.
            this.mTopASP.PlaceDirection = JCS_2D4Direction.TOP;
            this.mBottomASP.PlaceDirection = JCS_2D4Direction.BOTTOM;
            this.mLeftASP.PlaceDirection = JCS_2D4Direction.LEFT;
            this.mRightASP.PlaceDirection = JCS_2D4Direction.RIGHT;
        }

        private void Start()
        {
            JCS_ScreenSettings ss = JCS_ScreenSettings.instance;

            if (RESIZE_SCREEN_THIS_SCENE)
            {
                // Apply new screen aspect ratio.
                ss.ASPECT_RATIO_SCREEN_WIDTH = ASPECT_RATION_SCREEN_WIDTH_THIS_SCENE;
                ss.ASPECT_RATIO_SCREEN_HEIGHT = ASPECT_RATION_SCREEN_HEIGHT_THIS_SCENE;

                // Resize the screen base on the new screen aspect ratio.
                ss.ForceAspectScreenOnce();
            }

            // Set the panels' color
            SetResizablePanelsColor(ss.RESIZABLE_PANELS_COLOR);
        }

#if (UNITY_EDITOR)
        private void Update()
        {
            JCS_ScreenSettings ss = JCS_ScreenSettings.instance;

            /* Handle color. */
            {
                // Make color editable in runtime.
                SetResizablePanelsColor(ss.RESIZABLE_PANELS_COLOR);
            }

            /* Show hide the panels. */
            {
                if (ss.SHOW_RESIZABLE_PANELS)
                    ShowResizablePanels();
                else
                    HideResizablePanels();
            }
        }
#endif

        /// <summary>
        /// Show the resizable panels.
        /// </summary>
        public void ShowResizablePanels()
        {
            this.mTopASP.ShowPanel();
            this.mBottomASP.ShowPanel();
            this.mLeftASP.ShowPanel();
            this.mRightASP.ShowPanel();
        }

        /// <summary>
        /// Hide the resizable panels.
        /// </summary>
        public void HideResizablePanels()
        {
            this.mTopASP.HidePanel();
            this.mBottomASP.HidePanel();
            this.mLeftASP.HidePanel();
            this.mRightASP.HidePanel();
        }

        /// <summary>
        /// Set the color to all resizable panels.
        /// </summary>
        /// <param name="newColor"></param>
        public void SetResizablePanelsColor(Color newColor)
        {
            this.mTopASP.image.color = newColor;
            this.mBottomASP.image.color = newColor;
            this.mLeftASP.image.color = newColor;
            this.mRightASP.image.color = newColor;
        }
    }
}
