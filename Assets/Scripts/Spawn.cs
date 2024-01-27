using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Spawn : MonoBehaviour
{
	[SerializeField] private GridManager gridm;
	[SerializeField] public int _maxHeight, _maxWidth;
	
	[SerializeField] private GameObject player;
	[SerializeField] public static GameObject[] wumpus;
	[SerializeField] public static GameObject[] bats;
	[SerializeField] public static GameObject[] hole;
	
	[SerializeField] private GameObject w;
	[SerializeField] private GameObject b;
	[SerializeField] private GameObject h;
	
	public static List<Vector3> loc = new List<Vector3>();
    // Start is called before the first frame update
    void Start()
    {
		wumpus = new GameObject[Menu.store[0]];
		bats = new GameObject[Menu.store[1]];
		hole = new GameObject[Menu.store[2]];
		
		_maxHeight = gridm.height;
		_maxWidth = gridm.width;
		Spawncc();
    }
	void Spawncc()
	{
		Vector3 random_player= new Vector3(Random.Range(0,_maxWidth), Random.Range(0,_maxHeight), 0);
		player.transform.position = random_player;
				
		List<Vector3> tot = new List<Vector3>();
		
		while (tot.Count <= Menu.store[0] + Menu.store[1] + Menu.store[2])
		{
			Vector3 x = new Vector3(Random.Range(0,_maxWidth), Random.Range(0,_maxHeight), 0);
			if (!tot.Contains(x) && x != random_player)
            {
                tot.Add(x);
            }
			//Debug.Log(tot[i]);
		}
		
		
		for (int i = 0; i < Menu.store[0]; i++)
		{
			wumpus[i] = w;
			//Instantiate(W, tot[i], Quaternion.identity);
			//Debug.Log(tot[i]);
			random(wumpus[i], tot[i]);
			loc.Add(tot[i]);
		}
		for (int i = 0; i < Menu.store[1]; i++)
		{
			bats[i] = b;
			//Instantiate(B, tot[i], Quaternion.identity);
			//Debug.Log(tot[i]);
			random(bats[i], tot[i + Menu.store[0]]);
			loc.Add(tot[i + Menu.store[0]]);
		}
		for (int i = 0; i < Menu.store[2]; i++)
		{
			hole[i] = h;
			//Instantiate(H, tot[i], Quaternion.identity);
			//Debug.Log(tot[i]);
			random(hole[i], tot[i + Menu.store[0] + Menu.store[1]]);
			loc.Add(tot[i + Menu.store[0] + Menu.store[1]]);
		}
		
	}
	
	void random(GameObject obj, Vector3 post)
	{
		GameObject clone = Instantiate(obj, post, Quaternion.identity);
		clone.name = obj.name;
		clone.transform.parent = transform;	
	}
}