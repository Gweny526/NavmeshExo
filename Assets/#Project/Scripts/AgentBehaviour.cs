using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentBehaviour : MonoBehaviour
{
    // SOLUTION Thomas
 
    [SerializeField] Transform target;
 
    private NavMeshAgent agent;
    private Vector3 startPosition;
 
    private Vector3 targetPosition;
 
    private bool isAtDestination {get{return agent.remainingDistance<=agent.stoppingDistance;}}
 
    private bool isComingBack= false;
 
    void Start(){
        agent= GetComponent<NavMeshAgent>();
        startPosition= transform.position;
        targetPosition= target.position;
        agent.SetDestination(target.position);
    }
 
    void Update()
    {
        if(isAtDestination){
            ChangeDestination();
        }
    }
 
    private void ChangeDestination()
    {
        if(isComingBack){
            agent.SetDestination(targetPosition);
        }else{
            agent.SetDestination(startPosition);
        }
 
        isComingBack = !isComingBack;
    }
}
