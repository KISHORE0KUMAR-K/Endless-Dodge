using Unity.VisualScripting;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Rotate(0,0,rotationSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            GameManager.instance.GameOver();
        }
        if(collision.gameObject.tag == "Ground")
        {
            GameManager.instance.IncrementScore();
            Destroy(gameObject);
        }
    }


}
