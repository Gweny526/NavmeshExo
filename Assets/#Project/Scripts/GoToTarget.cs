using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
 
[RequireComponent(typeof(NavMeshAgent))]
public class GoToTarget : MonoBehaviour
{
    [SerializeField] Transform target;
    // [SerializeField] Transform agentStartPos;
    private NavMeshAgent agent;
    private Vector3 agentStart;
    private bool isArrived = true;
 
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agentStart = transform.position;
        GoBack();
    }
 
    void Update()
    {
        
        if(agent.remainingDistance <= agent.stoppingDistance){

            isArrived = !isArrived;
            GoBack();
        }
    }

    void GoBack()
    {
        if(isArrived)
        {
            agent.SetDestination(target.position);
        }
        else
        {
            agent.SetDestination(agentStart);
        }
    }
}