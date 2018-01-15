using UnityEngine;

public class followplayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset; // stores 3 numbers (3 floats), good for data position (x,y,z coords).
	
	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
	}
}
