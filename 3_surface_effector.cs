using UnityEngine;

public class surface_effector : MonoBehaviour
{
    public float force = 1f;
    public float speed = 10f;
    private Rigidbody2D rb2d;
    private float movex; 
    private SpriteRenderer sr; // only for colour change

     void Start()
    {
       rb2d = GetComponent<Rigidbody2D>();
       sr = GetComponent<SpriteRenderer>();// only for colour change
    }

    //surface effect movement code without colour change
    void Update()
    {
         moveX = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.linearVelocity = new Vector2(rb2d.linearVelocity.x, force);
        }
    }
    void FixedUpdate()
    {
        rb2d.linearVelocity = new Vector2 (movex*speed,rb2d.linearVelocity.y);
    }

    //Colour chnage code 
    void Update()
    {
        movex = Input.GetAxis("Horizontal");
        rb2d.linearVelocity = new Vector2(movex*speed, rb2d.linearVelocity.y);    
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.linearVelocity = new Vector2(rb2d.linearVelocity.x, force);
        }
        if(Mathf.Abs(rb2d.linearVelocity.y) > 0.1f)
        {
            sr.color = Color.green;
        }
        else if (Mathf.Abs(movex) > 0.1f)
        {
            sr.color = Color.yellow;
        }
        else
        {
            sr.color = Color.white;
        }

}
}
