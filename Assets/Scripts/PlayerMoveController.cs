using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour {

	public GameObject player;
    public static float moveSpeed = 0.3f;
    Vector3 up = new Vector3(0f,0f,moveSpeed);
	Vector3 down= new Vector3(0f,0f,-moveSpeed);
    Vector3 right= new Vector3(moveSpeed,0f,0f);
    Vector3 left= new Vector3(-moveSpeed,0f,0f);

	
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            player.GetComponent<Player>().Move(player.transform.forward * moveSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) 
        {
            player.GetComponent<Player>().Move(-player.transform.forward * moveSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) 
        {
            player.GetComponent<Player>().Move(-player.transform.right* moveSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) 
        {
            player.GetComponent<Player>().Move(player.transform.right* moveSpeed);
        }
	}
}
