using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyContoller : MonoBehaviour
{
	public float speed=10;

    void Start () {
		// this._Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 currentPosition = gameObject.GetComponent<Transform> ().position;
		currentPosition.x -= speed;
		gameObject.GetComponent<Transform> ().position = currentPosition;

		// Check bottom boundary
		if (currentPosition.x <= -5) {
			this._Reset();
		}
	}

	private void _Reset() {
		Vector2 resetPosition = new Vector2 (5, 4);
		gameObject.GetComponent<Transform> ().position = resetPosition;
	}
}
