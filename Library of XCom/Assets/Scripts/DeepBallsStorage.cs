using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeepBallsStorage : MonoBehaviour
{
    private DeepBallsStorage() { }

    private static readonly Lazy<DeepBallsStorage> instance = new Lazy<DeepBallsStorage>(() => new DeepBallsStorage());
    public static DeepBallsStorage Instance { get { return instance.Value; } }
    public string TestingString { get; set; } 
    public Renderer selectionRenderer { get; set; }
    public Transform _selection { get; set; }

}
