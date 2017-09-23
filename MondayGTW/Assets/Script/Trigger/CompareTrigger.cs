using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GTWEditor;
using System;

public class CompareTrigger : MonoBehaviour,ITrigger {

    public CompareOperator op;
    private IGetNumber[] para = new IGetNumber[2];


    public bool IsTriggered(GameObject target)
    {
        if (para[0] == null || para[1] == null) return false;
        switch (op)
        {
            case CompareOperator.ABiggerThanB:
                return para[0].GetNumber(target) > para[1].GetNumber(target);
            case CompareOperator.ASmallerThanB:
                return para[0].GetNumber(target) < para[1].GetNumber(target);
            case CompareOperator.AEqualsToB:
                return para[0].GetNumber(target) == para[1].GetNumber(target);
            case CompareOperator.ABigOrEqualB:
                return para[0].GetNumber(target) >= para[1].GetNumber(target);
            case CompareOperator.ASmallOrEqualB:
                return para[0].GetNumber(target) <= para[1].GetNumber(target);
            default:
                return false;
        }
    }


	// Use this for initialization
	void Start () {
        Transform itr;

        itr = transform.FindChild("数值A");
        if (itr.childCount > 0)
        {
            para[0] = itr.GetChild(0).gameObject.GetComponent<IGetNumber>();
        }
        itr = transform.FindChild("数值B");
        if (itr.childCount > 0)
        {
            para[1] = itr.GetChild(0).gameObject.GetComponent<IGetNumber>();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
