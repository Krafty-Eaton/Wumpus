using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activator : MonoBehaviour
{
	[SerializeField] GameObject victory, lose;
    // Start is called before the first frame update
    void Start()
    {
        if(GameOver.k == 0)
		{
			victory.SetActive(true);
			lose.SetActive(false);
		}
		else
		{
			victory.SetActive(false);
			lose.SetActive(true);
		}
    }
}
