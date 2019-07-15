using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionEnterHandler : ActionHandlerBase
{
    private void OnCollisionEnter(Collision collision)
    {
        Invoke(collision.gameObject);
    }
}
