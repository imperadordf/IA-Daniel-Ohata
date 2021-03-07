using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorMovedorVector : MonoBehaviour
{
    //Esse vector3 position, pode ser tanto um transform para dar referencia ao objeto na Unity
    public Vector3 positionFinal;
    //Coloquei em lista para caso eu queira adicionar mais um para patrulhar e ja colocando qual vai ser a position por aqui
    public List<MovedorVector> listMove = new List<MovedorVector>();

    private void Start()
    {
        foreach(MovedorVector move in listMove)
        {
            move.posFinal = positionFinal;
        }
    }
}
