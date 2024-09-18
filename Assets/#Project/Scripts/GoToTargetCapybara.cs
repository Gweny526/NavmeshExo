using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class GoToTargetCapybara : AgentFollow
{
    [SerializeField] Transform target;
    

    protected override void Follow()
    {
        agent.SetDestination(target.position);
    }

    
}
