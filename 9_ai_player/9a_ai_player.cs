using UnityEngine;

public class ai_player : MonoBehaviour
{
    public Transform target;
public float speed = 3.5f;
private UnityEngine.AI.NavMeshAgent agent;

// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
{
    agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    agent.speed = speed;
}

// Update is called once per frame
void Update()
{
    if (target != null)
    {
    agent.SetDestination(target.position);
    }
}
}
