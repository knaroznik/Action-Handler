using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerExitHandler2D : ActionHandlerBase
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        Invoke(collision.gameObject);
    }
}
