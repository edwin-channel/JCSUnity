﻿/**
 * $File: JCS_2DScrollPlatform.cs $
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
    public class JCS_2DScrollPlatform 
        : JCS_2DPlatform
    {

        //----------------------
        // Public Variables

        //----------------------
        // Private Variables

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

        //----------------------
        // Protected Functions
        protected override bool OnTriggerEnter(Collider other)
        {
            if (base.OnTriggerEnter(other))
            {


                return true;
            }

            return false;
        }
        protected override bool OnTriggerExit(Collider other)
        {
            if (base.OnTriggerExit(other))
            {


                return true;
            }

            return false;
        }
        //----------------------
        // Private Functions

    }
}
