using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed = 10f;

    public void Move()
    {
        StartCoroutine(EMove());
    }

    private IEnumerator EMove()
    {
        while (true)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, this.transform.position + new Vector3(0, 1, 0), Time.deltaTime * speed);
            yield return new WaitForFixedUpdate();
        }
        
    }
}
