using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	public GameObject bullet;

    public static float moveSpeed = 0.1f;
    Vector3 up = new Vector3(0f,0f,moveSpeed);
    Vector3 down= new Vector3(0f,0f,-moveSpeed);
    Vector3 right= new Vector3(moveSpeed,0f,0f);
    Vector3 left= new Vector3(-moveSpeed,0f,0f);
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(up);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) 
        {
            transform.Translate(down);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) 
        {
            transform.Translate(left);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) 
        {
            transform.Translate(right);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
			Instantiate(bullet , transform.localPosition, Quaternion.identity);
        }
	}
}
