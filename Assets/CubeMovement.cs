using UnityEngine;
using System.Collections;

public class CubeMovement : MonoBehaviour {
	Vector3 rotateAxisVector;
	Vector3 rotateAroundAxisVector;

	float rotateDegree;
	float rotateDegreeCounter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( rotateDegreeCounter > 0) {

			transform.RotateAround (rotateAxisVector, rotateAroundAxisVector, rotateDegree * Time.deltaTime);
			rotateDegreeCounter -= Mathf.Abs( (rotateDegree * Time.deltaTime));
		}
	}


	public void RotateRight() {
		if (rotateDegreeCounter <= 0) {
			rotateAroundAxisVector = new Vector3 (0, 0, 1);
			rotateAxisVector = transform.position + new Vector3 (.5f, -.5f, .5f);
			rotateDegree = -90f;
			rotateDegreeCounter = Mathf.Abs (rotateDegree);	
		}
	}

	public void RotateLeft() {
		if (rotateDegreeCounter <= 0) {
			rotateAroundAxisVector = new Vector3 (0, 0, 1);
			rotateAxisVector = transform.position + new Vector3 (-.5f, -.5f, .5f);
			rotateDegree = 90f;
			rotateDegreeCounter = Mathf.Abs (rotateDegree);	
		}
	}

	public void RotateForward() {
		if (rotateDegreeCounter <= 0) {
			rotateAroundAxisVector = new Vector3 (1, 0, 0);
			rotateAxisVector = transform.position + new Vector3 (0f, -.5f, .5f);
			rotateDegree = 90f;
			rotateDegreeCounter = Mathf.Abs (rotateDegree);	
		}
	}

	public void RotateBack() {
		if (rotateDegreeCounter <= 0) {
			rotateAroundAxisVector = new Vector3 (1, 0, 0);
			rotateAxisVector = transform.position + new Vector3 (0f, -.5f, -.5f);
			rotateDegree = -90f;
			rotateDegreeCounter = Mathf.Abs (rotateDegree);	
		}
	}


}
