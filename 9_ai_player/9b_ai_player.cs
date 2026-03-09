using UnityEngine;

public class b_ai_player : MonoBehaviour
{
    public Transform player;
    public float detectionRange = 5.0f;
    private UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < detectionRange)
        {
            agent.SetDestination(player.position);
            Debug.Log("AI is chasing the player");

            float playerDistance = Vector3.Distance(player.position, agent.transform.position);
            Debug.Log(playerDistance);

            if (playerDistance < 0.7f)
            {
                Debug.Log("Enemy Wins!");
                StopGame();
            }
        }
        else
        {
            agent.ResetPath();
        }
    }

    void StopGame()
    {
        Debug.Log("Game Over! The enemy caught you.");
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}