using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomB : MonoBehaviour
{
	[SerializeField] private GameObject player;
	[SerializeField] private GameObject bat;
	[SerializeField] private GameObject wumpus;
	[SerializeField] private GameObject hole;
	// Update is called once per frame
	
	void Awake()
	{
		player = GameObject.Find("Body player");
		bat = GameObject.Find("Body bats");
		hole = GameObject.Find("Body hole");
		wumpus = GameObject.Find("Body wumpus");
	}
	
    void Update()
    {
		var p = player.transform.position;
		var b = bat.transform.position;
		var w = wumpus.transform.position;
		var h = hole.transform.position;
		
        if (p == b)
		{
			player.transform.position = new Vector3(Random.Range(0,5)*4, Random.Range(0,5)*4, 0);
			while( p == w || p == h)
				player.transform.position = new Vector3(Random.Range(0,5)*4, Random.Range(0,5)*4, 0);
		}
    }
}
