using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Developer : MonoBehaviour {

    [HideInInspector]
    public string Name;

    private bool hasProject = false;

	// Use this for initialization
	void Start () {
        Name = Names.GetRandomName();
        GetComponentInChildren<TextMesh>().text = Name;
        gameObject.name = Name;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        GameManager.GameController.DeactiveOldDeveloper();
        GameManager.GameController.ActiveClickedDeveloper(this);
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
