using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
	[SerializeField] public Text wum, bat, hol;
	public static int[] store = new int[3];
	/*void Awake()
	{
		wum = GameObject.Find("W").transform.Find("OptionValue").gameObject;
		bat = GameObject.Find("B").transform.Find("OptionValue").gameObject;
		hol = GameObject.Find("H").transform.Find("OptionValue").gameObject;
	}*/
    public void exit()
	{
		Application.Quit();
		Debug.Log("Game Exit");
	}
	
	public void play()
	{
		st();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
	public void st()
	{
		store[0] = int.Parse(wum.text);
		store[1] = int.Parse(bat.text);
		store[2] = int.Parse(hol.text);
	}
}
