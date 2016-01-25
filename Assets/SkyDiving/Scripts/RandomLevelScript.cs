using UnityEngine;
using System.Collections;

public class RandomLevelScript : MonoBehaviour 
{
	public static int RandomLevel()
	{
		int nextLevel = 0;

		while(nextLevel < 2 || nextLevel == Application.loadedLevel)
		{
			nextLevel = 2 + (2 * Random.Range(0, (Application.levelCount - 2) / 2)); //ULTIMATE LIFE CHANGING CODE
		}

		return nextLevel;
	} //End RandomLevel



	public static int current;

	public static int NextLevel()
	{
		int nextLevel = 0;

		while (nextLevel < 3 || nextLevel == current)
		{
			nextLevel = Random.Range( 3 , ( Application.levelCount - 1 ) ); 
		}

		return nextLevel;
	} //End NextLevel

}
