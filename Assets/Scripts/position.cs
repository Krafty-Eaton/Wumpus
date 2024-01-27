using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    [SerializeField] private GridManager gridm;
	[SerializeField] private int _maxHeight, _maxWidth;
	[SerializeField] private GameObject canva;
	[SerializeField] private GameObject pane;
	void Start()
	{
		_maxHeight = gridm.height;
		_maxWidth = gridm.width;
		var rect1 = canva.GetComponent<RectTransform>();
		var rect2 = pane.GetComponent<RectTransform>();
		rect1.sizeDelta = new Vector2(_maxHeight, _maxWidth);
		rect2.sizeDelta = new Vector2(_maxHeight, _maxWidth);
		post();
	}
	
	void post()
	{
		canva.transform.position = new Vector3(_maxWidth * 1.5f, (float)_maxHeight / 2 - 0.5f, 0);
		//7.5, 2, 0
		//9, 2.5, 0
		//canva.transform.position = new Vector3(
	}
	
}
