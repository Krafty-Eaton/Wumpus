using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;
using System;

public class Shoot : MonoBehaviour
{
	[SerializeField] private GameObject player;
	[SerializeField] private GameObject[] wumpus;
	private Vector3 [] wum = new Vector3[Menu.store[0]];
	private AudioSource audio;
	
	void Awake()
	{
		audio = GetComponent<AudioSource>();
	}
	
    void Update()
    {
		wumpus = GameObject.FindGameObjectsWithTag("Wumpus");
		var x = player.transform.position;
		
		for(int i = 0; i < wumpus.Length; i++)
			wum[i] = wumpus[i].transform.position;
        var post = transform.position;
		if(wumpus.Count() > 0)
		{
			if (Input.GetKey("space"))
			{
				if (Input.GetKeyDown("left"))
				{
					if (wum.Contains(x - new Vector3(1, 0, 0)))
					{
						audio.Play(0);
						Destroy(wumpus[Array.FindIndex(wum, loc => loc == (x - new Vector3(1, 0, 0)))]);
					}
				}
				else if (Input.GetKeyDown("right"))
				{
					if (wum.Contains(x + new Vector3(1, 0, 0)))
					{
						audio.Play(0);
						Debug.Log("BOOO RIGHT");
						Destroy(wumpus[Array.FindIndex(wum, loc => loc == (x + new Vector3(1, 0, 0)))]);
					}
				}
				else if (Input.GetKeyDown("up"))
				{
					if (wum.Contains(x + new Vector3(0, 1, 0)))
					{
						audio.Play(0);
						Debug.Log("BOOO UP");
						Destroy(wumpus[Array.FindIndex(wum, loc => loc == (x + new Vector3(0, 1, 0)))]);
					}
				}
				else if (Input.GetKeyDown("down"))
				{
					if (wum.Contains(x - new Vector3(0, 1, 0)))
					{
						audio.Play(0);
						Debug.Log("BOOO DOWN");
						Destroy(wumpus[Array.FindIndex(wum, loc => loc == (x - new Vector3(0, 1, 0)))]);
					}
				}
			}
		}
    }
}
