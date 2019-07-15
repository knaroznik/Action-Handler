using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionExitHandler2D : ActionHandlerBase
{
    private void OnCollisionExit2D(Collision2D collision)
    {
        Invoke(collision.gameObject);
    }
}
