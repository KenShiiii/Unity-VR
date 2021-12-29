using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_rotationMultiplier : MonoBehaviour
{
    public Text rMultiplier;
    // Use this for initialization
    void Start()
    {
        rMultiplier.text = "RotateMultiplier: ";
    }

    // Update is called once per frame
    private void Update()
    {
        rMultiplier.text = "RotateMultiplier: " + GameObject.Find("北極星").GetComponent<StarMovement>().rotateMultiplier.ToString();
    }
}
