using UnityEngine;  
using System.Collections;

public class HideAlpha : MonoBehaviour   
{  
	GameObject m_obj;

	void Start ()   
	{  
		m_obj = GameObject.Find("Line1");  
	}  
		
	void Update ()  
	{  

	}  

	void OnGUI()  
	{  

		if (Input.GetButtonUp("W"))  
		{  
			m_obj.GetComponent<Renderer>().material.color = new Color32(234,154,255,128);  
		}  

		if (Input.GetButtonUp("E"))  
		{  
			m_obj.GetComponent<Renderer>().material.color = new Color32(234,154,255,0);  
		}  

	}  
}