using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAngleController : MonoBehaviour {

	Vector2 lastMousePosition;
	Vector2 diff = new Vector2(0,0);
	public GameObject player;
	public float rotationSpeed = 2.1f;
	private Vector3 prevCameraRot;
	void Start () {
		prevCameraRot = Vector3.zero;
	}
	void Update () {
		// onDragStart
		if(Input.GetMouseButtonDown(0)){
			lastMousePosition = Input.mousePosition;
			prevCameraRot = new Vector3(
				player.transform.eulerAngles.x,
				player.transform.eulerAngles.y,
				0
			);
		}
		// whileDragging
		if(Input.GetMouseButton(0)){
			Vector2 diff = new Vector2(
				Input.mousePosition.x - lastMousePosition.x,
				Input.mousePosition.y - lastMousePosition.y
			);
			Debug.Log(diff);
			Vector3 cameraRot = new Vector3(
				prevCameraRot.x - rotationSpeed * diff.y,
				prevCameraRot.y + rotationSpeed * diff.x,
				0
			);
			player.transform.rotation = Quaternion.Euler(
				cameraRot.x,
				cameraRot.y,
				0
			);
		}
	}
}
