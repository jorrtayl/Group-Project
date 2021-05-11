// MoveTo.cs
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{

    public Transform goal;

    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = 5;
    }

    // Make "Players" follow each other in a line in Update
    void Update()
    {
        agent.destination = goal.position;
    }
}