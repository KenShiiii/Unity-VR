using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour {

	Renderer R1;

	void Start () {

		R1 = gameObject.GetComponent<Renderer>();
		
	}

	void HitByRaycast() //被射線打到時會進入此方法
	{
		if (Input.GetMouseButtonDown(0)) //當按下鍵盤 E 鍵時
		{
			if (R1.material.color== Color.green) //如果Renderer材質是綠色
			{
				R1.material.color = Color.red; //Renderer材質換成紅色
			}
			else
			{
				R1.material.color = Color.green; //Renderer材質換成綠色
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
