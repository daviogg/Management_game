using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Computer : MonoBehaviour {

    public Canvas AssignMenu;
    public Text DeveloperName;

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
        if (isAssigned || GameManager.GameController.ActiveDeveloper == null)
        {
            return;
        }

        assignedDeveloper = GameManager.GameController.ActiveDeveloper;
        assignedDeveloper.transform.position = transform.position;
        
        isAssigned = true;
        DeveloperName.text = assignedDeveloper.Name;

        Debug.Log("Assigned location to " + assignedDeveloper.Name);
    }   

    public void UnassignLocation()
    {
        if (!isAssigned)
        {
            return;
        }

        assignedDeveloper.transform.position = new Vector2(5.598057f, 0.95f);
        assignedDeveloper = null;
        isAssigned = false;

        DeveloperName.text = "None";

    }
}
