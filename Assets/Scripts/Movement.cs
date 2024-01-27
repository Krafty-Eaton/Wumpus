using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	[SerializeField] private GridManager gridm;
	[SerializeField] private int _maxHeight, _maxWidth;
	private AudioSource audio;
	
	private int k;
	void Awake()
	{
		audio = GetComponent<AudioSource>();
		k = 1;
	}
	void Start()
	{
		_maxHeight = gridm.height;
		_maxWidth = gridm.width;
	}
    // Update is called once per frame
    void Update()
    {
		
		var x = transform.position.x;
		var y = transform.position.y;
		var z = transform.position.z;
        if(!Input.GetKey("space"))
			if(Input.GetKeyDown("left") && x - 1 >= 0)
			{
				transform.localScale = new Vector3(-1, 1, 1);
				if (k == 0)
				{
					audio.Play(0);
					transform.position = new Vector3(x - 1, y, z);
				}
				k = 0;
				Debug.Log("Left Pressed");
			}
			else if(Input.GetKeyDown("right") && x + 1 < _maxWidth)
			{
				transform.localScale = new Vector3(1, 1, 1);
				if (k == 1)
				{
					audio.Play(0);
					transform.position = new Vector3(x + 1, y, z);
				}
				k = 1;
				Debug.Log("Right Pressed");
			}
			else if(Input.GetKeyDown("up") && y + 1 < _maxHeight)
			{
				transform.position = new Vector3(x, y + 1, z);
				audio.Play(0);
				Debug.Log("Up Pressed");	
			}
			else if(Input.GetKeyDown("down") && y - 1 >= 0)
			{
				transform.position = new Vector3(x, y - 1, z);
				audio.Play(0);
				Debug.Log("Down Pressed");
			}
    }
}
