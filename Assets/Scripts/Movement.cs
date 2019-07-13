using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        float xDiff = Input.GetAxisRaw("Horizontal");
        this.transform.position = Vector3.MoveTowards(this.transform.position, this.transform.position + new Vector3(xDiff, 0, 0), Time.deltaTime * speed);

    }
}
