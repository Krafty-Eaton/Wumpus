using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogDel : MonoBehaviour
{
    [SerializeField] GameObject player;
	[SerializeField] GameObject fog;
	void Update()
	{
		for(var i = fog.transform.childCount - 1; i >= 0; i--)
			if (player.transform.position == fog.transform.GetChild(i).transform.position)
			{
				Object.Destroy(fog.transform.GetChild(i).gameObject);
			}
	}
}
