using UnityEngine;

public class playerMovement : MonoBehaviour {

    //rb = reference to rigid body component on the IDE
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;


	// Update is called once per frame
    //Marked as fixed update as its used to mess with physics
    // and unity prefers it to be called this.
	void FixedUpdate ()
    {

        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // added Forcemore.velocity change
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
