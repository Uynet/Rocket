using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	public float bulletVelocity = 25.0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += bulletVelocity * transform.forward * Time.deltaTime;	
	}
}
