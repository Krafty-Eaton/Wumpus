using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
		var x = transform.position.x;
		var y = transform.position.y;
		var z = transform.position.z;
		
        if(Input.GetKeyDown("left") && x - 4 >= 0)
		{
			transform.position = new Vector3(x - 4, y, z);
			Debug.Log("Left Pressed");
		}
		else if(Input.GetKeyDown("right") && x + 4 <= 16)
		{
			transform.position = new Vector3(x + 4, y, z);
			Debug.Log("Right Pressed");
		}
		else if(Input.GetKeyDown("up") && y + 4 <= 16)
		{
			transform.position = new Vector3(x, y + 4, z);
			Debug.Log("Up Pressed");
		}
		else if(Input.GetKeyDown("down") && y - 4 >= 0)
		{
			transform.position = new Vector3(x, y - 4, z);
			Debug.Log("Down Pressed");
		}
    }
}
