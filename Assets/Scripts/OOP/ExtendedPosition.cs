using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyOOP
{
    public static class ExtendedMethods
    {
        public static void MoveUp(this Transform transform, float step)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + step, transform.position.z);
        }
    }
}