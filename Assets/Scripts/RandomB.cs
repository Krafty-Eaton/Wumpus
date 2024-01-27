using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomB : MonoBehaviour
{
	[SerializeField] private GameObject player;
	[SerializeField] private GameObject[] bats;
	//[SerializeField] private GridManager gridm;
	
	[SerializeField] private GridManager gridm;
	[SerializeField] private int _maxHeight, _maxWidth;
	
	
	void Awake()
	{
		player = GameObject.FindWithTag("Player");
		
	}
	void Start()
	{
		bats = GameObject.FindGameObjectsWithTag("Random");
		_maxHeight = gridm.height;
		_maxWidth = gridm.width;
	}
    void Update()
    {
		var p = player.transform.position;
		for(int i = 0; i < bats.Length; i++)
		{
			if (p == bats[i].transform.position)
			{
				p = new Vector3(Random.Range(0, _maxWidth), Random.Range(0, _maxHeight), 0);
				while(Spawn.loc.Contains(p))
					p = new Vector3(Random.Range(0, _maxWidth), Random.Range(0, _maxHeight), 0);
				break;
			}
		}
		player.transform.position = p;
    }
}
