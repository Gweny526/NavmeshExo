using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
 
// [RequireComponent(typeof(NavMeshAgent))]
public class GoToMouse : AgentFollow
{
    
 
    protected override void Follow()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit)) 
        {
            agent.SetDestination(hit.point);
        }
    }
}