using UnityEngine;
using System.Collections;

public class Escape : MonoBehaviour
{
	// public
	public int windowWidth = 400;
	public int windowHight = 150;
	public int check = 0;

	// private
	Rect windowRect ;
	int windowSwitch = 0;
	float alpha = 0;

	void GUIAlphaColor_0_To_1 ()
	{
		if (alpha < 1) {
			alpha += Time.deltaTime;
			GUI.color = new Color (1, 1, 1, alpha);
		}
	}

	// Init
	void Awake ()
	{
		windowRect = new Rect (
			(Screen.width - windowWidth) / 2,
			(Screen.height - windowHight) / 2,
			windowWidth,
			windowHight);
	}

	void Update ()
	{
		if (Input.GetKeyDown ("escape")) {
			if (check == 0) {
				check += 1;
				windowSwitch = 1;
				alpha = 0; // Init Window Alpha Color
			} 
			else {
				check = 0;
			}
		}
	}

	void OnGUI ()
	{
		if (windowSwitch == 1) {
			GUIAlphaColor_0_To_1 ();
			windowRect = GUI.Window (0, windowRect, QuitWindow, "離開視窗");
		}
	}

	void QuitWindow (int windowID)
	{
		GUI.Label (new Rect (100, 50, 300, 30), "               確定要離開嗎?");

		if (GUI.Button (new Rect (80, 110, 100, 20), "離開")) {
			Application.Quit ();
		}
		if (GUI.Button (new Rect (220, 110, 100, 20), "取消")) {
			windowSwitch = 0;
		}
		if (Input.GetKeyDown ("escape")) {
			windowSwitch = 0;
		}

		GUI.DragWindow ();
	}

}