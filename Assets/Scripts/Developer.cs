using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Developer : MonoBehaviour {

    [HideInInspector]
    public string Name;
    [HideInInspector]
    public Project Project { get; set; }
    
    public TextMesh TextName;
        
    private bool hasProject = false;    

	// Use this for initialization
	void Start () {
        Name = Names.GetRandomName();
        gameObject.name = Name;
        TextName.text = Name;
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void AssignProject() //Assign this developer to a project
    {
        if (!hasProject)
        {
            // Project = 
            hasProject = true;
            Debug.Log("Project assigned to " + Name);
        }
    }

    private void OnMouseDown()
    {
        GameManager.GameController.DeactiveOldDeveloper();
        GameManager.GameController.ActiveClickedDeveloper(this);
    }
}
