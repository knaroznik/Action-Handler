using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionEnterHandler2D : MonoBehaviour
{
    public UnityEvent collisionAction;

    public bool PlayOnce;
    public bool PlayerCollision;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (PlayerCollision)
        {
            if (collision.gameObject.tag == "Player")
            {
                Play();
            }
        }
        else
        {
            Play();
        }
    }

    private void Play()
    {
        collisionAction.Invoke();

        if (PlayOnce)
        {
            Destroy(this);
        }
    }
}
