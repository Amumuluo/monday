using GTWEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ConstNumber : MonoBehaviour, IGetNumber
{
    [Header("用作比较的常量值")]
    public float Num = 0;
    public float GetNumber(GameObject target)
    {
        return Num;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
