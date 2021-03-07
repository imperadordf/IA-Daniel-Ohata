using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedorContinuo : MonoBehaviour
{
    public List<Transform> listPosistion = new List<Transform>();
    int contPos;
    public float speed;
    bool ultimo;
    private void Update()
    {
        

        if (Vector3.Distance(listPosistion[contPos].position,transform.position)>2)
        {
            Vector3 destination = listPosistion[contPos].position - transform.position;
            transform.Translate(destination.normalized * speed * Time.deltaTime );
        }
        else
        {
            contPos++;
           
            if (ultimo)
                this.enabled = false;
            else if (contPos == listPosistion.Count)
            {
                contPos-=2;
                ultimo = true;
            }
            
        }
    }
}
