using GTWEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using GTWEditor.GetNumber;

public class TargetPosGet : MonoBehaviour,IGetNumber {

    [Header("使用X坐标还是Y坐标")]
    public PosGetUseXOrY useWhat;
    public float GetNumber(GameObject target)
    {
        if(useWhat == PosGetUseXOrY.UseX)
            return target.transform.position.x;
        return target.transform.position.y;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
