using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBasedMovement : MonoBehaviour
{

    private bool isMoving;
    private float smoothTimer;
    private Vector3 originalpos, targetpos;
    private float movementTime = 0.1f;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector3(0,0,0);

        if (Input.GetKey(KeyCode.UpArrow) && !isMoving)
        {
            //  StartCoroutine(Smooth(Vector3.forward));
            dir = new Vector3 (dir.x, dir.y, 1);
        }
        if (Input.GetKey(KeyCode.DownArrow) && !isMoving)
        {
            //   StartCoroutine(Smooth(Vector3.forward * -1));
            dir = new Vector3(dir.x, dir.y, -1);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && !isMoving)
        {
            //   StartCoroutine(Smooth(Vector3.left));
            dir = new Vector3(-1, dir.y, dir.z);
        }

        if (Input.GetKey(KeyCode.RightArrow) && !isMoving)
        {//
         //  StartCoroutine(Smooth(Vector3.right));
            dir = new Vector3(1, dir.y, dir.z);
        }

        dir = dir.normalized;
        StartCoroutine(Smooth(dir));

    }

    private IEnumerator Smooth(Vector3 direction)
    {
        isMoving = true;

        float elapsedTime = 0;

        //Calulating Positions for next move
        originalpos = transform.position;
        targetpos = originalpos + direction;

        while (elapsedTime < movementTime)
        {
            //   transform.position = Vector3.Lerp(originalpos, targetpos, (elapsedTime / movementTime) * Time.deltaTime);
            transform.position = Vector3.Lerp(originalpos, targetpos, speed * Time.deltaTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

      //  transform.position = targetpos;

        isMoving = false;

    }
}
