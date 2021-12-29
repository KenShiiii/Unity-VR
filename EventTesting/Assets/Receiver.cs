using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour {
    EventHappened e;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //this.e.MessageSent += delegate(object sender, EventHappened.OnMessageSent e);
        this.e.MessageSent += e.OnMessageSent;
}
