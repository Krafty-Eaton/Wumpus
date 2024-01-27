using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
	[SerializeField] public int width, height;
	[SerializeField] private Tile tileprefab;
	[SerializeField] private Transform cameras;
	[SerializeField] private Camera field;
    // Start is called before the first frame update
    void Start()
    {
		cameras.transform.position = new Vector3(width - 0.5f, height/2, -11);
		field.fieldOfView = 45;
        generate();
    }

    void generate()
	{
		for(int i = 0; i < width; i++)
			for(int j = 0; j < height; j++)
			{
				var spawnTile = Instantiate(tileprefab, new Vector3(i, j), Quaternion.identity);
				spawnTile.name = $"Tile {i} {j} ";
				spawnTile.transform.parent = transform;
			}
	}
}
