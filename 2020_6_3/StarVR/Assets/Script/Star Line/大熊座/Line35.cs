﻿using UnityEngine;
using System.Collections;
using System.Threading;

public class Line35 : MonoBehaviour {

	private GameObject LineRenderGameObject;
	private LineRenderer lineRenderer;
	GameObject Star1;
	GameObject Star2;
	Vector3 Star1Position;
	Vector3 Star2Position;

	void Start(){
		LineRenderGameObject = GameObject.Find ("Line35");
		Star1 = GameObject.Find ("文昌4");
		Star2 = GameObject.Find ("三台二");
		Star1Position = Star1.transform.position;
		Star2Position = Star2.transform.position;
		lineRenderer = (LineRenderer)LineRenderGameObject.GetComponent ("LineRenderer");
		lineRenderer.SetWidth (0.1f, 0.1f);
	}	

	void Update() {
		lineRenderer.SetPosition (0, Star1.transform.position);
		lineRenderer.SetPosition (1, Star2.transform.position);

	}
}