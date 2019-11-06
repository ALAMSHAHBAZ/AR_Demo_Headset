using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionScript : MonoBehaviour
{
    public GameObject selectedObject=null;
    public bool isScaled = false;
    private Vector3 oldScaling;



    void OnMouseDown()
    {
        selectedObject = GameObject.Find(CastingToObject.selectedObject);
        oldScaling = selectedObject.GetComponent<Renderer>().transform.localScale;
        if (isScaled == false)
        {
            selectedObject.GetComponent<Renderer>().transform.localScale = oldScaling + new Vector3(0.2f, 0.2f);
            isScaled = true;
        }
        
    }
    void OnMouseExit()
    {
        selectedObject.GetComponent<Renderer>().transform.localScale = oldScaling;
        isScaled = false;
    }
}

