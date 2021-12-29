using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedButtonHandler : MonoBehaviour {

    public delegate void OnButtonClicked();
    public static event OnButtonClicked onSpeedUpClicked;
    public static event OnButtonClicked onSpeedDownClicked;
    public static event OnButtonClicked onPlayClicked;


    public void changeMultiplierUp()
    {
        if (onSpeedUpClicked != null)
        {
            onSpeedUpClicked();
        }
    }
    public void changeMultiplierDown()
    {
        if (onSpeedDownClicked != null)
        {
            onSpeedDownClicked();
        }
    }
    public void playOrPause()
    {
        if(onPlayClicked != null)
        {
            onPlayClicked();
        }

    }
}
