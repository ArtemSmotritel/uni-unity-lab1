using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelCompleteEventManager : MonoBehaviour
{
    private static UnityEvent levelCompleteEvent = new UnityEvent();
    private volatile bool isFirstCollision = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (!this.isFirstCollision)
        {
            levelCompleteEvent.Invoke();
            this.isFirstCollision = true;
        }
    }

    public static void AddEventListener(UnityAction action)
    {
        levelCompleteEvent.AddListener(action);
    }

    public static void RemoveEventListener(UnityAction action)
    {
        levelCompleteEvent.RemoveListener(action);
    }
}
