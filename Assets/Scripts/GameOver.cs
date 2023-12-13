using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    void Start()
    {
        Gameover();
    }

    // Update is called once per frame
    void Update()
    {
		
    }
	void Gameover()
	{
		if(transform.position == GameObject.FindWithTag("Enemy").transform.position)
		{
			Debug.Log("Game Over");
		}
	}
}
