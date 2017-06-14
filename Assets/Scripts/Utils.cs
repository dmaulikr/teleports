﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Teleports.Utils
{
    public static class Utils
    {
        public static void makeVisible(this GameObject gameObject)
        {
            gameObject.transform.localScale = Vector3.one;
        }

        public static void makeInvisible(this GameObject gameObject)
        {
            gameObject.transform.localScale = Vector3.zero;
        }
    }
}
public class Utils : MonoBehaviour {

	
}