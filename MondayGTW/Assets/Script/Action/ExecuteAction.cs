using GTWEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ExecuteAction : MonoBehaviour,IAction {
    public void Action(GameObject target)
    {
        int cnt = child.Count;
        for(int i = 0; i < cnt; i++)
        {
            child[i].Action(target);
        }
    }

    private List<IAction> child;
    // Use this for initialization
    void Start () {
        child = new List<IAction>();
        IAction itr = null;

        int cnt = transform.childCount;

        for (int i = 0; i < cnt; i++)
        {
            itr = transform.GetChild(i).gameObject.GetComponent<IAction>();
            if (itr != null)
            {
                child.Add(itr);
            }
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
