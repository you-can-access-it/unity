using UnityEngine;

public class degree_1 : MonoBehaviour
{
    // degree checker

    [SerializeField] Transform target;
    [SerializeField] float moveSpeed = 5f;
    void Update()
{
    var direction = target.position - transform.position;
    var directionToTarget = direction.normalized;
    var dotproduct = Vector3.Dot(transform.forward, directionToTarget);
    var angle = Mathf.Acos(dotproduct);
    Debug.LogFormat("Angle to target {0} is {1} degrees", target.name, angle * Mathf.Rad2Deg);

    float moveX = Input.GetAxis("Horizontal");
    float moveZ = Input.GetAxis("Vertical");

    Vector3 moveDirection = new Vector3(moveX, 0, moveZ);
    transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
}


//  range checker 
    [SerializeField] float range = 5;
    private bool targetWasInRange = false;
void Update()
    {
        var distance = (target.position - transform.position).magnitude;
        if(distance <=range && targetWasInRange == false)
        {
            Debug.LogFormat("Target {0} entered range", target.name);
            targetWasInRange = true;
        }
        else if(distance > range && targetWasInRange == true)
        {
            Debug.LogFormat("Target {0} exited range", target.name);
            targetWasInRange = false;
        }
    }
}
