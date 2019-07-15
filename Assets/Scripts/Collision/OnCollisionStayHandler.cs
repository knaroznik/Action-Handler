using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionStayHandler : ActionHandlerBase
{
    private void OnCollisionStay(Collision collision)
    {
        Invoke(collision.gameObject);
    }
}
