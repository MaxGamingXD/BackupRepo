using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 0.25f;
    [SerializeField] public float rayLength = 1.4f;

    //Ray offset, for diagonal lines, allows for a flush finish
    [SerializeField] public float rayoffsetX = 0.5f;
    [SerializeField] public float rayoffsetY = 0.5f;
    [SerializeField] public float rayoffsetZ = 0.5f;

    Vector3 targetPosition;
    Vector3 startPosition;

    bool moving;
    // Start is called before the first frame update
    void Start()
    {
        moving = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetButtonDown("Fire1"))
        {
            targetPosition = transform.position + Vector3.forward;
            moving = true;
        }

        if (Vector3.Distance(transform.position, targetPosition) > snapDistance && moving == true)
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        else
        {
            transform.position = targetPosition;
            moving = false;
        }*/

        if (moving == true)
        {
            if (Vector3.Distance(startPosition, transform.position) > 1f)
            {
                transform.position = targetPosition;
                moving = false;
                return;
            }

            transform.position += (targetPosition - startPosition) * moveSpeed * Time.deltaTime;
            return;
        }

        

        if (Input.GetKeyDown(KeyCode.W))
        {
            if(canMove(Vector3.forward))
            {
                targetPosition = transform.position + Vector3.forward;
                startPosition = transform.position;
                moving = true;
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (canMove(Vector3.back))
            {
                targetPosition = transform.position + Vector3.back;
                startPosition = transform.position;
                moving = true;
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (canMove(Vector3.left))
            {
                targetPosition = transform.position + Vector3.left;
                startPosition = transform.position;
                moving = true;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (canMove(Vector3.right))
            {
                targetPosition = transform.position + Vector3.right;
                startPosition = transform.position;
                moving = true;
            }
        }
    }

    bool canMove(Vector3 direction)
    {
        if (Vector3.Equals(Vector3.forward,direction) || Vector3.Equals(Vector3.back, direction))
        {
            if (Physics.Raycast(transform.position + Vector3.up * rayoffsetY + Vector3.right * rayoffsetX, direction, rayLength)) return false;
            if (Physics.Raycast(transform.position + Vector3.up * rayoffsetY - Vector3.right * rayoffsetX, direction, rayLength)) return false;
        }
        else if (Vector3.Equals(Vector3.left, direction) || Vector3.Equals(Vector3.right, direction))
        {
            if (Physics.Raycast(transform.position + Vector3.up * rayoffsetY + Vector3.right * rayoffsetZ, direction, rayLength)) return false;
            if (Physics.Raycast(transform.position + Vector3.up * rayoffsetY - Vector3.right * rayoffsetZ, direction, rayLength)) return false;
        }
        return true;
    }
}
