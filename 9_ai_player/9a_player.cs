using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
{
rb = GetComponent<Rigidbody>();
}
// Update is called once per frame
void FixedUpdate()
{
float h = Input.GetAxis("Horizontal");
float v = Input.GetAxis("Vertical");

Vector3 move = new Vector3(h, 0, v) * speed;
rb.linearVelocity = new Vector3(move.x, rb.linearVelocity.y, move.z);
}
}
