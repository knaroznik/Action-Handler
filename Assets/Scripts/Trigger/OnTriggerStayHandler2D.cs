using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerStayHandler2D : ActionHandlerBase
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        Invoke(collision.gameObject);
    }
}
