using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionStayHandler2D : ActionHandlerBase
{
    private void OnCollisionStay2D(Collision2D collision)
    {
        Invoke(collision.gameObject);
    }
}
