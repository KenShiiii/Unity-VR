using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TimeSynchronize : MonoBehaviour {
    static string defaultTime = "6/1/2020 20:00:00";

    public class OnSynchronizeEventArgs: EventArgs
    {
        TimeSpan duration = DateTime.Now.Subtract(DateTime.Parse(defaultTime));
    }
    public event EventHandler<OnSynchronizeEventArgs> OnSynchronize;

	// Use this for initialization
	void Start () {
        TimeSpan duration = DateTime.Now.Subtract(DateTime.Parse(defaultTime));
       
	}
	
	// Update is called once per frame
	void Update () {
        TimeSpan duration = DateTime.Now.Subtract(DateTime.Parse(defaultTime));
        Debug.Log(duration);
        Debug.Log(duration.TotalSeconds);
	}
}
