using GTWEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppRoot : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(this);
        ResolutionMgr.SetResolution(540, 960, true,60);
        GTWConsole.Awake();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// FixedUpdate is called once per frame before Update
	void FixedUpdate () {
        TouchSimulator.Update();
    }

    void OnGUI()
    {
        if(GUI.Button(new Rect(0,ResolutionMgr.RealHeight - 90,160,90),("Console: "+ GTWConsole.IsOpen))){
            GTWConsole.IsOpen = !GTWConsole.IsOpen;
        }
        GTWConsole.Update();
    }
}
