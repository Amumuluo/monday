using GTWEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PrintInConsole : MonoBehaviour,IAction {
    public string Text;
    public void Action(GameObject target)
    {
        GTWConsole.Log(Text);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
