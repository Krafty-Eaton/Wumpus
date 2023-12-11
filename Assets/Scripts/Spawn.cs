using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	[SerializeField] private GameObject player;
	[SerializeField] private GameObject wumpus;
	[SerializeField] private GameObject bats;
	[SerializeField] private GameObject hole;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPlayers();
		random(wumpus);
		random(bats);
		random(hole);
    }
	
	void SpawnPlayers()
	{
		Vector3 random_player= new Vector3(Random.Range(0,5)*4, Random.Range(0,5)*4, 0);		
		player.transform.position = random_player;
		var p = player.transform.position;
		var b = bats.transform.position;
		var w = wumpus.transform.position;
		var h = hole.transform.position;
		
		if(p == b || b == w || b == h)
		{
			Destroy(bats);
			random(bats);
		}
		if(p == h || h == w || b == h)
		{
			Destroy(hole);
			random(hole);
		}
		if(p == w || b == w || w == h)
		{
			Destroy(wumpus);
			random(wumpus);
		}
	}
	
	void random(GameObject obj)
	{
		Vector3 random_player= new Vector3(Random.Range(0,5)*4, Random.Range(0,5)*4, 0);
		Instantiate(obj, random_player, Quaternion.identity);
	}
}
