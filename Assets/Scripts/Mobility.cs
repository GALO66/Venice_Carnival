using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mobility : MonoBehaviour
{
    public GameObject Target;
    public NavMeshAgent Agent;

    // Start is called before the first frame update
    void Start()
    {
        Agent = this.GetComponent<NavMeshAgent>();
        Agent.SetDestination(Target.transform.position);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
