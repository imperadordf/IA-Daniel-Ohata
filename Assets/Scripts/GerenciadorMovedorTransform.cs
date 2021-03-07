using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorMovedorTransform : MonoBehaviour
{
    public Transform positionTarget;
    public List<MovedorTransform> listMove = new List<MovedorTransform>();

    private void Start()
    {
        foreach (MovedorTransform move in listMove)
        {
            move.positionTarget = positionTarget;
        }
    }
}
