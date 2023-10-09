using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string PlayerTag = "Player";
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material pressedMaterial;
    [SerializeField] private Material defaultMaterial;

    public bool isHighlighted;
    public bool isPressed;

    //Holds data for what transform is being selected
    private Transform _selection;

    private void Start()
    {
        isPressed = false;
        isHighlighted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_selection != null)
        {
            isHighlighted = false;
            DeepBallsStorage.Instance.selectionRenderer = _selection.GetComponent<Renderer>();
            DeepBallsStorage.Instance.selectionRenderer.material = defaultMaterial;
            DeepBallsStorage.Instance._selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(PlayerTag))
            {
                DeepBallsStorage.Instance.selectionRenderer = selection.GetComponent<Renderer>();
                if (DeepBallsStorage.Instance.selectionRenderer != null)
                {
                    isHighlighted = true;
                    Debug.Log(DeepBallsStorage.Instance.TestingString);

                    /*if (Input.GetMouseButtonDown(0))
                    {
                        selectionRenderer.material = pressedMaterial;
                    }*/
                }

                _selection = selection;
            }
        }

        if (isHighlighted == true)
        {
            isPressed = true;
            DeepBallsStorage.Instance.selectionRenderer.material = highlightMaterial;
        }
        else if (isPressed == true && Input.GetMouseButtonDown(0))
        {
            DeepBallsStorage.Instance.selectionRenderer.material = pressedMaterial;
        }
    }
    
        
        /*if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }*/

        /*var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(PlayerTag))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = highlightMaterial;
                }

                _selection = selection;
            }
        }*/
    
}
