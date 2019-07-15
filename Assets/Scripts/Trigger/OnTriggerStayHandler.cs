using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerStayHandler : ActionHandlerBase
{
    private void OnTriggerStay(Collider other)
    {
        Invoke(other.gameObject);
    }
}
