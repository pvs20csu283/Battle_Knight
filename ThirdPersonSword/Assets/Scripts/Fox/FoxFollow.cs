using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxFollow : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent Fox;
    public Transform Player;

    void Start()
    {

    }

    void Update()
    {
        Fox.SetDestination(Player.position);
    }
}
