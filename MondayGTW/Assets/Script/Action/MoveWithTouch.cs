using GTWEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveWithTouch : MonoBehaviour,IAction {
    public void Action(GameObject target)
    {
        if (TouchSimulator.touchCount > 0)
        {
            var dp = TouchSimulator.GetTouch(0).deltaPosition;
            target.transform.position += new Vector3(dp.x, 0, 0);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
