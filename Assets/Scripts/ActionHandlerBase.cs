using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionHandlerBase : MonoBehaviour, IActionHandler
{
    public UnityEvent collisionAction;

    public bool PlayOnce;
    public bool PlayerCollision;

    public void Invoke(GameObject obj)
    {
        if (PlayerCollision)
        {
            if (obj.tag == "Player")
            {
                Play();
            }
        }
        else
        {
            Play();
        }
    }

    public  void Play()
    {
        collisionAction.Invoke();

        if (PlayOnce)
        {
            Destroy(this);
        }
    }
}
