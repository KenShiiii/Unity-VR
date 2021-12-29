using UnityEngine;  
using System.Collections;  

public class HideRenderer : MonoBehaviour   
{  
	public GameObject[] lines;

	void Start ()   
	{  
		lines = GameObject.FindGameObjectsWithTag("Line");  
	}  

	void OnGUI()  
	{  

		if (Input.GetButtonUp("W"))  
		{  
			for (int i = 0; i < lines.Length; i++) 
			{
				lines[i].GetComponent<Renderer> ().enabled = true;  
			}
		}  

		if (Input.GetButtonUp("E"))  
		{
			for (int i = 0; i < lines.Length; i++) 
			{
				lines[i].GetComponent<Renderer> ().enabled = false;  
			}
		}  

	}  
}