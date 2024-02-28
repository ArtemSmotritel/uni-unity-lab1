using UnityEngine;

namespace MyOOP
{
    public class MethodOverloading : MonoBehaviour
    {
        public void Move(Vector3 direction, float distance)
        {
            transform.Translate(direction * distance);
        }

        public void Move(Vector3 destination)
        {
            transform.position = destination;
        }
    }
}
