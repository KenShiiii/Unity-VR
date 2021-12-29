using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarLine : MonoBehaviour {
	public GameObject[] lines;
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
		lines = GameObject.FindGameObjectsWithTag ("Line");
		if (check < 0) {
			for (int i = 0; i < lines.Length; i++) {
				lines [i].GetComponent<Renderer> ().enabled = false;  
			}
		} else {
			for (int i = 0; i < lines.Length; i++) {
				lines [i].GetComponent<Renderer> ().enabled = true;  
			}
		}
	}
}