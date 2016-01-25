using UnityEngine;
using System.Collections;

public class DiverScript : MonoBehaviour 
{
	Animator anim;
	public float fallSpeed = 3;
	bool win = false;
	//TimerScript timer;

	void Awake () 
	{
	//	GameObject.FindGameObjectWithTag("Timer").GetComponent <TimerScript>(); 
	//	timer.Play();    
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		rigidbody2D.velocity = rigidbody2D.transform.up * -fallSpeed;

		if (Input.GetKeyDown(KeyCode.Space))
		{
			anim.SetBool("pressed", true);
			win = true;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(win)
		{
		//	timer.Pause();
			Application.LoadLevel(2);
		}
		else
		{
		//	timer.parent.enabled = false;
			Application.LoadLevel(1);
		}
	}
}
