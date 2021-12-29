using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventHappened : MonoBehaviour {
    public class OnMessageSent : EventArgs {
        public string message = "Hello World!";
    }
    public event EventHandler MessageSent;
    public delegate void EventHandler(object sender, EventArgs e);  
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (MessageSent != null)
        {
            MessageSent(this, OnMessageSent.Empty);
        }
	}
}
