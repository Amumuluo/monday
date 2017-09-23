using GTWEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var cma = GetComponent<Camera>();
        if(cma.orthographic)
            cma.orthographicSize = ResolutionMgr.TargetHeight / 2;
	}
	
	// Update is called once per frame
	void Update () {
		if(DyncConfig.MainCharactor != null)
        {
            var pos = transform.position;
            pos.y = DyncConfig.MainCharactor.transform.position.y;
            transform.position = pos;
        }
	}
}
