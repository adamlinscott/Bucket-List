using UnityEngine;
using System.Collections;

public class RoomScript : MonoBehaviour 
{
	public float timeCounter = Random;
	ScoreScript score;

	void Awake()
	{
		score = GameObject.FindGameObjectWithTag("Timer").GetComponent<TimerScript>();
	}

	//Update is called once per frame
	void Update()
	{
		if (Time.deltaTime > timeCounter)
		{
			InitiateLevel.IntroLevel(RandomLevelScript.NextLevel());
			score.AddScore(10);
		}

		if (Input.anyKeyDown)
		{
			Application.LoadLevel(1);
		}
	}
}
