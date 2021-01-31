using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float velocity = 13.0f;
		transform.position += velocity * transform.forward * Time.deltaTime;	
	}
}
