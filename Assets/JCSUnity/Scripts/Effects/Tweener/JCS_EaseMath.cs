﻿/**
 * $File: JCS_EaseMath.cs $
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
    /// Easing Equation can be find here.
    /// 
    /// URL: http://gizma.com/easing/#quint1
    /// GitHub: https://github.com/PeterVuorela/Tweener (Third Party Library)
    /// </summary>
    public class JCS_EaseMath
        : MonoBehaviour
    {
       public static float Linear(float time, float from, float to, float duration)
        {
            return to * time / duration + from;
        }
    }
}
