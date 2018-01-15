using UnityEngine;

public class playercollision : MonoBehaviour {

    public playerMovement movement;
   


	void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obsticle")
        {
           movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
