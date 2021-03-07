using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedorVector : MonoBehaviour
{
   
    public Vector3 posFinal;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
    }

    
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(posFinal,transform.position)>1)
        {
            Vector3 direction = posFinal - transform.position;
            transform.position += direction.normalized *speed * Time.deltaTime;
        }
        else
        {
            enabled = this;
        }
            
       
    }

    Vector3 posInicial;
}
