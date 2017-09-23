using GTWEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovementAction : MonoBehaviour,IAction {
    public GameObject MoveScript;
    public bool ChangeX;
    public bool ChangeY;
    private AutoMoveForward AMF;
    public void Action(GameObject target)
    {
        if(AMF != null)
        {
            if (ChangeX)
                AMF.speedX *= -1;
            if (ChangeY)
                AMF.speedY *= -1;
        }
    }

    // Use this for initialization
    void Start()
    {
        if (MoveScript != null)
        {
            AMF = MoveScript.GetComponent<AutoMoveForward>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
