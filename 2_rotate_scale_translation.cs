using UnityEngine;

public class prac1_a : MonoBehaviour
{
    public float speed = 10f;
    public float scaleSpeed = 1f;
    public float minScale = 0.2f;
    public float maxScale = 5f;
    private Rigidbody2D rb2d;

    void Start()
    {
       rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //translation
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(x,y);
        rb2d.linearVelocity = movement * speed;

        //rotation
        transform.Rotate(0,0,-x*speed*Time.deltaTime);

        //scale
        float scaleInput = Input.GetAxis("Vertical");
        Vector3 newScale = transform.localScale + Vector3.one * scaleInput * scaleSpeed * Time.deltaTime;
        newScale.x = Mathf.Clamp(newScale.x, minScale, maxScale);
        newScale.y = Mathf.Clamp(newScale.y, minScale, maxScale);
        newScale.z = 1f;
        transform.localScale = newScale;
    }
}