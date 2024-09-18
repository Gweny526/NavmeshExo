using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public abstract class AgentFollow : MonoBehaviour
{
    protected NavMeshAgent agent; //protected pour qu'il soit accessible que par les enfant

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Follow();
    }
    protected abstract void Follow();
}
