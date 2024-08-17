using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChikenCome : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    // Update is called once per frame  
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
