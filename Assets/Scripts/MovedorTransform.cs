using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedorTransform : MonoBehaviour
{
    [HideInInspector]
    public Transform positionTarget;

    public float speed;
    Vector3 posFinal;
   
    void Update()
    {
        posFinal = positionTarget.position;
        if (Vector3.Distance(posFinal, transform.position) > 1)
        {
            Vector3 direction = posFinal - transform.position;
            transform.position += direction.normalized * speed * Time.deltaTime;
        }
        else
        {
            enabled = this;
        }
    }
}
