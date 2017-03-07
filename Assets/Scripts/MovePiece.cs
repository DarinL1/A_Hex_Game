using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePiece : MonoBehaviour {
	
	public Vector3 targetPosition;
	public float x;
	public float y;

	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//targetPosition.Set(targetPosition.x, targetPosition.y, 0.0f);
			//print(transform.position);
			//transform.position = targetPosition;   // Imediately Sets Position


			x = ((Mathf.Round ((1 / 0.88f) * targetPosition.x)));
			y = ((Mathf.Round (2 * targetPosition.y)) / 2);
			if (Mathf.Abs(x % 2) == 0f) {
				// Even Number
				Debug.Log("Even number");
				y = (Mathf.Round(y));
			}
				
			if (Mathf.Abs(x % 2) == 1f) {
				// Odd number
				Debug.Log("Odd number");
				y = (Mathf.Round(y+0.5f)-0.5f);
			}

			Debug.Log (targetPosition.x);
			Debug.Log (targetPosition.y);
			Debug.Log (x);
			Debug.Log (y);


			targetPosition.Set(x * 0.88f, y, 0.0f);

		}

		transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 2);


	}


}
