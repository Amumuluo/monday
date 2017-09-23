using GTWEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CalculateBool : MonoBehaviour,ITrigger {
    [Header("运算符")]
    public TriggerOperator op;
    [Header("无子节点时是否默认为true")]
    public bool defaultTrue;
    private List<ITrigger> mytgr;

    // Use this for initialization
    void Start () {
        mytgr = new List<ITrigger>();

        ITrigger itr = null;

        int cnt = transform.childCount;

        for (int i = 0; i < cnt; i++)
        {
            itr = transform.GetChild(i).gameObject.GetComponent<ITrigger>();
            if (itr != null)
            {
                mytgr.Add(itr);
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    public bool IsTriggered(GameObject target)
    {
        int cnt = mytgr.Count;
        if (cnt < 1) return defaultTrue;

        bool rlt = mytgr[0].IsTriggered(target);
        for(int i = 1; i < cnt; i++)
        {
            rlt = Operate(rlt, mytgr[i].IsTriggered(target));
        }

        return rlt;
    }

    private bool Operate(bool a,bool b)
    {
        if (op == TriggerOperator.And)
            return a && b;
        else
            return a || b;
    }

}
