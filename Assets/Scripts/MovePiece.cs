using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePiece : MonoBehaviour {
	
	public Vector3 targetPosition;

	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			targetPosition.Set(targetPosition.x, targetPosition.y, 0.0f);
			//print(transform.position);
			//transform.position = targetPosition;   // Imediately Sets Position

		}

		transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 2);

	}
}
