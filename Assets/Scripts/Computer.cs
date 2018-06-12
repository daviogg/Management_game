using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour {

    public Canvas AssignMenu;

    private bool isAssigned = false;
    private Developer assignedDeveloper;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnMouseDown()
    {        
        AssignMenu.enabled = !AssignMenu.enabled;
        Debug.Log("Pannello aperto");
    }

    public void AssignLocation() //Assign this location to a developer
    {
        if (isAssigned)
        {
            return;
        }

        assignedDeveloper = GameManager.GameController.ActiveDeveloper;
        assignedDeveloper.transform.position = transform.position;
        
        isAssigned = true;
        Debug.Log("Assigned location to " + assignedDeveloper.Name);
    }   

    public void UnassignLocation()
    {
        assignedDeveloper.transform.position = new Vector2(5.598057f, 0.95f);
        assignedDeveloper = null;
        isAssigned = false;
    }
}
