using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionEnterHandler2D : ActionHandlerBase
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Invoke(collision.gameObject);
    }
}
