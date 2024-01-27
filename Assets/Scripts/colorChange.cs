using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorChange : MonoBehaviour
{
    /*public Color startcolor = Color.red;
	public Color endcolor = Color.green;
	[Range(0,10)]
	public float speed = 1;
	
	SpriteRenderer img;
	void Awake()
	{
		img = GetComponent<SpriteRenderer>();
	}
	
	void Update()
	{
		img.color = Color.Lerp(startcolor, endcolor, Mathf.PingPong(Time.time * speed, 1));
	}*/
	[SerializeField] private Color[] colors;
	private int current = 0;
	private int last = 1;
	private float target;
	[SerializeField] private float time = 0.06f;
	
	private SpriteRenderer img;
	void Awake()
	{
		img = GetComponent<SpriteRenderer>();
	}
	
	void Update()
	{
		target += Time.deltaTime/time;
		img.color = Color.Lerp(colors[current], colors[last], target);
		if(target >= 1)
		{
			target = 0;
			current = last;
			last++;
			if(last == colors.Length)
				last = 0;
		}
	}
}
