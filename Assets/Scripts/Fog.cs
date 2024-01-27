using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog : MonoBehaviour
{
	[SerializeField] private GridManager gridm;
    [SerializeField] private int _maxHeight, _maxWidth;
	[SerializeField] private GameObject fogprefab;
	
	void Awake()
	{
		_maxHeight = gridm.height;
		_maxWidth = gridm.width;
	}
	
	void Start()
	{
		generate();
	}
	
	void generate()
	{
		for(int i = 0; i < _maxWidth; i++)
			for(int j = 0; j < _maxHeight; j++)
			{
				var spawnTile = Instantiate(fogprefab, new Vector3(i, j), Quaternion.identity);
				spawnTile.name = $"Fog {i} {j} ";
				spawnTile.transform.parent = transform;
			}
	}
}
