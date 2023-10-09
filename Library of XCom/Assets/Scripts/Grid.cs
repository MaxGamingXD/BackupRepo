using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField] private Transform forward;
    //[SerializeField] private Transform backward;
    //[SerializeField] private Transform left;
    //[SerializeField] private Transform right;
    [SerializeField] private float speed;

    [Header ("Transform")]
    [SerializeField] private Transform transleft;

    [SerializeField] private Transform character;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            character.position = forward.position;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            character.position = transleft.position;
        }
    }
}