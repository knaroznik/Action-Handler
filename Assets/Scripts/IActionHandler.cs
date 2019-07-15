using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IActionHandler
{
    void Invoke(GameObject obj);
    void Play();
}
