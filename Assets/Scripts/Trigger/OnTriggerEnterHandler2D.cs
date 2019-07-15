using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnterHandler2D : ActionHandlerBase
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Invoke(collision.gameObject);
    }
}
