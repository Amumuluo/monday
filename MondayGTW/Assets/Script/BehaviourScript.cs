using GTWEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourScript : MonoBehaviour {

    private ITrigger trigger;
    private IAction action;
    private GameObject target;

    // Use this for initialization
    void Start () {
        trigger = transform.FindChild("trigger").gameObject.GetComponent<ITrigger>();
        action = transform.FindChild("action").gameObject.GetComponent<IAction>();
        target = transform.parent.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
		if(null != trigger)
        {
            if (trigger.IsTriggered(target))
            {
                if (null != action)
                {
                    action.Action(target);
                }
            }
        }
    }
}
