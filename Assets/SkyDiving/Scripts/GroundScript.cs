using UnityEngine;
using System.Collections;

public class GroundScript : MonoBehaviour 
{
	System.Random rand = new System.Random();
	// Use this for initialization
	void Start () 
	{
		rigidbody2D.transform.position =  new Vector3 (0, rand.Next(-50, -10), 10);
	}
}
