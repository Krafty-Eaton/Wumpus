using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    void Update()
    {
		Gameover();		
    }
	void Gameover()
	{
		if(transform.position == GameObject.FindWithTag("Wumpus").transform.position ||
		transform.position == GameObject.FindWithTag("Hole").transform.position)
		{
			Debug.Log("Game Over");
		}
	}
}
