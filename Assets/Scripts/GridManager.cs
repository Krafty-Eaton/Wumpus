using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
	[SerializeField] private int width, height;
	[SerializeField] private Tile tileprefab;
	[SerializeField] private Transform camera;
	[SerializeField] private Camera field;
    // Start is called before the first frame update
    void Start()
    {
		camera.transform.position = new Vector3(15, 8, -10);
		field.fieldOfView = 100;
        generate();
    }

    void generate()
	{
		for(int i = 0; i < width; i+=4)
			for(int j = 0; j < height; j+=4)
			{
				var spawnTile = Instantiate(tileprefab, new Vector3(i, j), Quaternion.identity);
				spawnTile.name = $"Tile {i/4} {j/4} ";
			}
	}
}
