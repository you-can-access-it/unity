using UnityEngine;

public class goal : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("Player"))
    {
    Debug.Log("player wins");
    Time.timeScale = 0;
    }

    else if (other.gameObject.CompareTag("Enemy"))
    {
    Debug.Log("Ai Win");
    Time.timeScale = 0;
}
}
}
