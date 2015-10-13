using UnityEngine;
using System.Collections;

public class CubeMovement : MonoBehaviour {
	Vector3 rotateAxisVector;
	Vector3 rotateAroundAxisVector;

	Quaternion targetRotationQ;

	float rotateDegree;
	float rotateDegreeCounter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (rotateDegreeCounter);
		if (rotateDegreeCounter > 1) {
			if (targetRotationQ != null && transform.rotation != targetRotationQ) {
				//float degChange = rotateDegree * Time.deltaTime;
				float degChange = rotateDegree * Time.deltaTime;

				transform.RotateAround (rotateAxisVector, rotateAroundAxisVector, degChange);
				rotateDegreeCounter -= Mathf.Abs ((degChange));
			} 
		}
		else  {
			transform.rotation = targetRotationQ;
			targetRotationQ = transform.rotation;
			rotateDegreeCounter = 0;
		}

	}


	public void RotateRight() {
		if (rotateDegreeCounter <= 0) {
			rotateAroundAxisVector = new Vector3 (0, 0, 1);
			rotateAxisVector = transform.position + new Vector3 (.5f, -.5f, .5f);
			rotateDegree = -90f;
			rotateDegreeCounter = Mathf.Abs (rotateDegree);	

			Vector3 currentRotation = transform.rotation.eulerAngles;
			Vector3 targetRotation = currentRotation + (rotateDegree * rotateAroundAxisVector);

			targetRotationQ = Quaternion.Euler(targetRotation);
		}
	}

	public void RotateLeft() {
		if (rotateDegreeCounter <= 0) {
			rotateAroundAxisVector = new Vector3 (0, 0, 1);
			rotateAxisVector = transform.position + new Vector3 (-.5f, -.5f, .5f);
			rotateDegree = 90f;
			rotateDegreeCounter = Mathf.Abs (rotateDegree);	

			Vector3 currentRotation = transform.rotation.eulerAngles;
			Vector3 targetRotation = currentRotation + (rotateDegree * rotateAroundAxisVector);
			
			targetRotationQ = Quaternion.Euler(targetRotation);
		}
	}

	public void RotateForward() {
		if (rotateDegreeCounter <= 0) {
			rotateAroundAxisVector = new Vector3 (1, 0, 0);
			rotateAxisVector = transform.position + new Vector3 (0f, -.5f, .5f);
			rotateDegree = 90f;
			rotateDegreeCounter = Mathf.Abs (rotateDegree);	

			
			Vector3 currentRotation = transform.rotation.eulerAngles;
			Vector3 targetRotation = currentRotation + (rotateDegree * rotateAroundAxisVector);
			
			targetRotationQ = Quaternion.Euler(targetRotation);
		}
	}

	public void RotateBack() {
		if (rotateDegreeCounter <= 0) {
			rotateAroundAxisVector = new Vector3 (1, 0, 0);
			rotateAxisVector = transform.position + new Vector3 (0f, -.5f, -.5f);
			rotateDegree = -90f;
			rotateDegreeCounter = Mathf.Abs (rotateDegree);	

			
			Vector3 currentRotation = transform.rotation.eulerAngles;
			Vector3 targetRotation = currentRotation + (rotateDegree * rotateAroundAxisVector);
			
			targetRotationQ = Quaternion.Euler(targetRotation);
		}
	}


}
