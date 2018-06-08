using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour {

    public Canvas AssignMenu;

    private bool isAssigned = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnMouseDown()
    {        
        AssignMenu.enabled = !AssignMenu.enabled;
        Debug.Log("Ciaodiaocao");
    }

    public void AssignLocation()
    {
        if (isAssigned)
        {
            return;
        }

        // get active developer
        // assign this to him
        isAssigned = true;
        Debug.Log("Assigned");
    }

   
}
