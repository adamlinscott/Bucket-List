using UnityEngine;
using System.Collections;

public class TurtleScript : MonoBehaviour 
{
	public float speed = 5f;
	
	void Awake()
	{
		gameObject.transform.position = new Vector3(Random.Range(0,10), -2, 0);
	}
	// Update is called once per frame
	void Update () 
	{
		rigidbody2D.velocity = new Vector2(-speed, 0);
	}
}
