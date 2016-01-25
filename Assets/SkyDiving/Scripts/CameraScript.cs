using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour //class CameraScript
{
	public Transform objectToFollow; //public Transform variable
	private Vector3 objectPosition; //private Vector3 variable

	// Update is called once per frame
	void Update() //Update method
	{
		if (objectToFollow != null) // If the object to follow is set to something.
		{
			objectPosition = objectToFollow.transform.position; // Update the position of the object

			transform.position = new Vector3(objectPosition.x, objectPosition.y, objectPosition.z - 10);	// Set the position of the camera to objectPosition
		} //end if
	} //end Update
} //end class