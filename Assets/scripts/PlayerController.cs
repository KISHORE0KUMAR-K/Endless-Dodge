using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;
    SpriteRenderer sp;
    private void Awake()
    {
        rb  = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }

        void Start()
    {
        
    }
 
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if(Input.GetMouseButton(0)){
            if(Input.mousePosition.x < Screen.width / 2)
            { 
                rb.linearVelocity = Vector2.left * moveSpeed;
                sp.flipX = true;
            }
            else{
                rb.linearVelocity = Vector2.right * moveSpeed;
                  sp.flipX = false;
            }
        }
    }
}
