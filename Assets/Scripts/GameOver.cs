using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject player;
	[SerializeField] private GameObject[] wumpus;
	[SerializeField] private GameObject[] holes;
	public static int k;
    void Update()
    {
		wumpus = GameObject.FindGameObjectsWithTag("Wumpus");
		holes = GameObject.FindGameObjectsWithTag("Hole");
		
		Vector3 [] wum = new Vector3[wumpus.Length];
		Vector3 [] hol = new Vector3[holes.Length];
	
		for(int i = 0; i < wumpus.Length; i++)
			wum[i] = wumpus[i].transform.position;
		
		for(int i = 0; i < holes.Length; i++)
			hol[i] = holes[i].transform.position;
		
		var x = player.transform.position;
		/*if(hol.Contains(x) || wum.Contains(x))
		{
			k = 1;
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
		if (wumpus.Count() == 0)
		{
			k = 0;
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}*/
    }
}
