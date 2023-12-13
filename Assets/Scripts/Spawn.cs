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
		//random(wumpus);
		//random(bats);
		//random(hole);
    }
	
	void SpawnPlayers()
	{
		Vector3 random_player= new Vector3(Random.Range(0,5)*4, Random.Range(0,5)*4, 0);
		Vector3 random_wumpus= new Vector3(Random.Range(0,5)*4, Random.Range(0,5)*4, 0);
		Vector3 random_bats= new Vector3(Random.Range(0,5)*4, Random.Range(0,5)*4, 0);
		Vector3 random_hole= new Vector3(Random.Range(0,5)*4, Random.Range(0,5)*4, 0);
		var p = player.transform.position = random_player;
		var b = bats.transform.position = random_bats;
		var w = wumpus.transform.position = random_wumpus;
		var h = hole.transform.position = random_hole;
		Debug.Log(p);
		Debug.Log(b);
		Debug.Log(w);
		Debug.Log(h);
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
