using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager GameController;

    public GameObject CurrentActive; //Active developer container
    public GameObject DeveloperPool;

    [HideInInspector]
    public Developer ActiveDeveloper;

    // Use this for initialization
    void Start () {
        GameController = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ActiveClickedDeveloper(Developer toActivate) //Set the clicked Developer as active
    {
        toActivate.transform.parent = CurrentActive.transform;        
        ActiveDeveloper = toActivate;

        ActiveDeveloper.GetComponentsInChildren<SpriteRenderer>()[1].enabled = true;

    }

    public void DeactiveOldDeveloper() //Set the clicked Developer as active
    {        
        if (ActiveDeveloper != null)
        {
            ActiveDeveloper.GetComponentsInChildren<SpriteRenderer>()[1].enabled = false;
            ActiveDeveloper.transform.parent = DeveloperPool.transform;
        }
    }
}
