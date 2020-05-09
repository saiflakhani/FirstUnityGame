
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public hmmscript movement;
    
    // Start is called before the first frame update
    void OnCollisionEnter(Collision info)
    {
        if(info.collider.tag == "Obstacle"){
            Debug.Log("We hit an obstacle");
            movement.enabled = false;
            FindObjectOfType<GameManager1>().EndGame();
        }
    }
}
