using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Developer : MonoBehaviour {

    [HideInInspector]
    public string Name;

    private bool hasProject = false;

	// Use this for initialization
	void Start () {
        Name = "Gianfernando";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AssignProject() //
    {
        if (!hasProject)
        {
            hasProject = true;
            Debug.Log("Project assigned to " + Name);
        }
    }
}
