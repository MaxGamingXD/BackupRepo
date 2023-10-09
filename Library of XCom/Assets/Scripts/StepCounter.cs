using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepCounter : MonoBehaviour
{
    private string classTypes;
    private string classDec;

    [SerializeField] public int currentSteps;
    [SerializeField] public int maxSteps;

    public string ClassTypes
    {
        get { return classTypes; }
        set { classTypes = value; }
    }

    public string ClassDec
    {
        get { return classDec; }
        set { classDec = value; }
    }

    public int MaxSteps
    {
        get { return maxSteps; }
        set { maxSteps = value; }
    }

}
