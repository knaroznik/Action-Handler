using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionExitHandler : ActionHandlerBase
{
    private void OnCollisionExit(Collision collision)
    {
        Invoke(collision.gameObject);
    }
}
