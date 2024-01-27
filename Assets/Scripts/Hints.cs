using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hints : MonoBehaviour
{
	[SerializeField] private GameObject player;
	[SerializeField] private GameObject[] wumpus;
	[SerializeField] private GameObject[] bats;
	[SerializeField] private GameObject[] hole;
	[SerializeField] private Text texthint;
	
	private Vector3[] w = new Vector3[Menu.store[0]];
	private Vector3[] b = new Vector3[Menu.store[1]];
	private Vector3[] h = new Vector3[Menu.store[2]];
	
	private float[] pw = new float[Menu.store[0]];
	private float[] pb = new float[Menu.store[1]];
	private float[] ph = new float[Menu.store[2]];
	
	//private string[] ch = new string[3];
	void Start()
	{
		
	}

    // Update is called once per frame
    void Update()
    {
		wumpus = GameObject.FindGameObjectsWithTag("Wumpus");
		bats = GameObject.FindGameObjectsWithTag("Random");
		hole = GameObject.FindGameObjectsWithTag("Hole");
        gen_hint();
    }
	//--- Find with tag----
	void gen_hint()
	{
		Vector3 p = player.transform.position;
		string[] ch = new string[3];
		texthint.text = "";
		for(int i = 0; i < wumpus.Length; i++)
		{
			w[i] = wumpus[i].transform.position;
			pw[i] = Vector3.Distance(p, w[i]);
			
			if (pw[i] == 1 || pw[i] == -1)
			{
				ch[2] = "Smell a Stench ";
			}
		}
		for(int i = 0; i < bats.Length; i++)
		{
			b[i] = bats[i].transform.position;
			pb[i] = Vector3.Distance(p, b[i]);
			if (pb[i] == 1 || pb[i] == -1)
			{
				ch[0] = "Hear a Flap ";
			}
			
		}
		for(int i = 0; i < hole.Length; i++)
		{
			h[i] = hole[i].transform.position;
			ph[i] = Vector3.Distance(p, h[i]);
			if (ph[i] == 1 || ph[i] == -1)
			{
				ch[1] = "Feel a Breeze ";
			}
			
		}
		
		
		
		/*
		if (pb == 1 || pb == -1)
		{
			ch[0] = "Hear a Flap ";
		}
		if (ph == 1 || ph == -1)
		{
			ch[1] = "Feel a Breeze ";
		}
		if (pw == 1 || pw == -1)
		{
			ch[2] = "Smell a Stench ";
		}
		*/
		for( int i = 0; i < 3; i++)
			texthint.text += ch[i];
	}
}
