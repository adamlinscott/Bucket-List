using UnityEngine;
using System.Collections;

public class JumpScript : MonoBehaviour 
{
	Animator anim;
	bool jumped = false;
	public Vector2 jumpForce = new Vector2(0, 3);
	bool inAir = false;
	ScoreScript score;

	void Awake()
	{
		anim = GetComponent<Animator>();
		score = GameObject.FindGameObjectWithTag("Timer").GetComponent<TimerScript>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space) && !jumped)
		{
			anim.SetBool("jump", true);
			jumped = true;
			rigidbody2D.AddForce(jumpForce); 
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "ground")
		{
			inAir = false;
		}


		if (inAir && other.tag == "Finish")
		{
			score.AddScore(10);
			InitiateLevel.IntroLevel(RandomLevelScript.NextLevel());
			Debug.Log("win");
		}
		else if (other.tag == "Finish")
		{
			Application.LoadLevel(1);
			Debug.Log("lose");
		}
	}

	void OnTriggerExit2D(Collider2D ground)
	{
		if (ground.tag == "ground")
		{
			inAir = true;
		}
	}
}