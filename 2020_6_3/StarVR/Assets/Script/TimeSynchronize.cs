using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeSynchronize : MonoBehaviour
{

    static string defaultTime = "6/1/2020 20:00:00";

    public delegate void SynchronizeHandler(TimeSpan timeDifference);
    public static event SynchronizeHandler onSynchronized;

    void Start()
    {
        TimeSpan duration = DateTime.Now.Subtract(DateTime.Parse(defaultTime));
        if (onSynchronized != null)
        {
            onSynchronized(duration);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //TimeSpan duration = DateTime.Now.Subtract(DateTime.Parse(defaultTime));
        //Debug.Log(duration);
        //Debug.Log(duration.TotalSeconds);
    }
}