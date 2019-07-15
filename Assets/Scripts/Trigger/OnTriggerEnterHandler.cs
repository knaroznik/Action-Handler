using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnterHandler : ActionHandlerBase
{
    private void OnTriggerEnter(Collider other)
    {
        Invoke(other.gameObject);
    }
}
