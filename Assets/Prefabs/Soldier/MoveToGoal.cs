using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToGoal : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        GameObject goal = GameObject.FindWithTag("Goal");
        anim.SetFloat("speed", agent.speed);
        agent.SetDestination(goal.transform.position);
    }
}
