// MoveTo.cs
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{

    public Transform goal;

    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.speed = 5;
        agent.destination = goal.position;
    }

    // Make "Players" follow each other in a line in Update
    void Update()
    {
        
    }
}