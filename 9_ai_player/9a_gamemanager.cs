using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public GameObject player;
    public GameObject ai;
    public GameObject goal;

    void Update()
    {
        float playerDistance = Vector3.Distance(player.transform.position, goal.transform.position);
        float aiDistance = Vector3.Distance(ai.transform.position, goal.transform.position);

        if (playerDistance < 1.0f)
        {
            Debug.Log("Player Wins!");
            QuitGame();
        }
        else if (aiDistance < 1.0f)
        {
            Debug.Log("AI wins!");
            QuitGame();
        }
    }

    void QuitGame()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
