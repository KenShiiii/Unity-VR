using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planerenderer : MonoBehaviour {
	public GameObject planes;
	public int check = 1;
	void Start()
	{
		Button btn = GetComponent<Button>();
		btn.onClick.AddListener(delegate
			{
				Click();
			});
	}

	public void Click ()
	{

		Debug.Log ("Button Clicked. StarLine.");
		check = check * (-1);
		planes = GameObject.Find("Plane");
		if (check < 0)
			planes.GetComponent<Renderer> ().enabled = false;
		else
			planes.GetComponent<Renderer> ().enabled = true;
	}
}