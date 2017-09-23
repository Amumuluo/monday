using GTWEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RectCollideTestWithMainCharactor : MonoBehaviour,ITrigger {
    public float Halfwidth;
    public float HalfHeight;
    public bool IsTriggered(GameObject target)
    {
        if (DyncConfig.MainCharactor == null) return false;
        var mcPos = DyncConfig.MainCharactor.transform.position;
        var tgtPos = target.transform.position;
        if (Math.Abs(mcPos.x - tgtPos.x) <= Halfwidth + DyncConfig.HalfMainCharactorWidth)
        {
            if(Math.Abs(mcPos.y - tgtPos.y) <= HalfHeight + DyncConfig.HalfMainCharactorHeight)
            {
                return true;
            }
        }
        return false;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
