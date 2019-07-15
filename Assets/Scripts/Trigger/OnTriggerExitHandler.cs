using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerExitHandler : ActionHandlerBase
{
    private void OnTriggerExit(Collider other)
    {
        Invoke(other.gameObject);
    }
}
