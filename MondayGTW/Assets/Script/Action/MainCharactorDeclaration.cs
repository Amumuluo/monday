using GTWEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainCharactorDeclaration : MonoBehaviour,IAction {

    bool NotFinish = true;

    public float MainCharactorWidth;
    public float MainCharactorHeight;

    public void Action(GameObject target)
    {
        if (NotFinish)
        {
            DyncConfig.MainCharactor = target;
            DyncConfig.HalfMainCharactorWidth = MainCharactorWidth;
            DyncConfig.HalfMainCharactorHeight = MainCharactorHeight;
            NotFinish = false;
        }
    }

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
