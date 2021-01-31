using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject bullet;

    public void Move(Vector3 diff){
        transform.Translate(diff);
    }
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
			Instantiate(bullet , transform.localPosition, transform.rotation);
        }
	}
}
