using GTWEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClickTrigger : MonoBehaviour,ITrigger {
    private bool touchUp;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool IsTriggered(GameObject go)
    {
        if (TouchSimulator.touchCount > 0)
        {
            if (touchUp)
            {
                touchUp = false;
                return true;
            }
        }
        else
        {
            touchUp = true;
        }
        return false;
    }
}
