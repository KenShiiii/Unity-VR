using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StarMovement : MonoBehaviour
{
    Vector3 rotationAxis = new Vector3((float)-0.330997, (float)37.9698, (float)92.5104);
    double rotateAxisToOriginDistance;

    float starDistance, cosTheta, radius;
    Vector3 origin = new Vector3(0, 0, 0);

    Vector3 rotatePosition;
    float rCos; // Radius x cosTheta
    float proportion; //proportion of [origin to rotate point / Radius]

    public int rotateMultiplier = 1;
    int tempMultiplier;
    float rotateDegree = (float)0.00041695205;
    // float originRotateDegree = (float)0.00041695205;


    // Start is called before the first frame update
    void Start()
    {
        //rotateAxisToOriginDistance = Vector3.Distance(rotationAxis, origin);
        //Debug.Log(rotateAxisToOriginDistance);


        Vector3 originPosition = transform.position;

        starDistance = Vector3.Distance(rotationAxis, transform.position);
        radius = Vector3.Distance(rotationAxis, origin);
        cosTheta = ((2 * Mathf.Pow(radius, 2)) - Mathf.Pow(starDistance, 2)) / (2 * Mathf.Pow(radius, 2)); //餘弦定理
        rCos = radius * cosTheta;   // Radius x cosTheta
        proportion = rCos / radius; //proportion of [origin to rotate point / Radius]
        rotatePosition = new Vector3(rotationAxis.x * proportion, rotationAxis.y * proportion, rotationAxis.z * proportion);//Rotate Point
        float rotatePointDistance = Vector3.Distance(origin, rotatePosition); 

        SpeedButtonHandler.onSpeedUpClicked += MultiplierUp;
        SpeedButtonHandler.onSpeedDownClicked += MultiplierDown;
        SpeedButtonHandler.onPlayClicked += PlayOrPause;

        TimeSynchronize.onSynchronized += Synchronize;
        

        TimeTickSystem.OnTick += delegate (object sender, TimeTickSystem.OnTickEventArgs e)
        {
            transform.RotateAround(rotatePosition, rotationAxis, rotateDegree / 2 * rotateMultiplier);
        };
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.X))
        {
            MultiplierUp();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            MultiplierDown();
        }
        //transform.RotateAround(rotatePosition, solarisPosition, (float)0.0041666666);
    }
    void MultiplierUp()
    {
        if (rotateMultiplier < 10000)
            rotateMultiplier *= 2;
        Debug.Log("Button Clicked");
    }
    void MultiplierDown()
    {
        if (rotateMultiplier > 1)
            rotateMultiplier /= 2;
    }
    void PlayOrPause()
    {
        if(rotateMultiplier != 0)
        {
            tempMultiplier = rotateMultiplier;
            rotateMultiplier = 0;
        }
        else
        {
            rotateMultiplier = tempMultiplier;
        }
    }
    void Synchronize(TimeSpan timeDifference)
    {
         //   Debug.Log("Synchronize Event.");
        double duration = timeDifference.TotalSeconds;
        long durationInt = Convert.ToInt64(Math.Round(duration));
        durationInt %= 86400;
        durationInt /= 10;
    
        transform.RotateAround(rotatePosition, rotationAxis, rotateDegree);
    }
}
