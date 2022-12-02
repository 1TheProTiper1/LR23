using UnityEngine;

public class Obstacle : MonoBehaviour
{  
    void Start()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            FindObjectOfType<Player>().PlayerDead();
        }
    }
    public void RemoveObstacle()
    {
        //ball hit hoot remove it
        Destroy(gameObject);
    }
}
