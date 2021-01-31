using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject bullet;
    public float shootOffset = 1;

    void Start(){
        
    }
    public void Move(Vector3 diff){
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.MovePosition(transform.position + diff);
    }
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetMouseButtonDown(0))
        {
			Instantiate(bullet , transform.localPosition + transform.forward * shootOffset, transform.rotation);
        }
	}
}
