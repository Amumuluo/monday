using GTWEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AutoMoveForward : MonoBehaviour,IAction {
    public void Action(GameObject target)
    {
        target.transform.position += new Vector3(speedX * Time.deltaTime, speedY * Time.deltaTime, 0);
        dt += Time.deltaTime;
        //if (dt > 0.1f)
        //{
        //    dt = 0;
        //    GameObject go = GameObject.Instantiate(prefab);
        //    go.transform.position = target.transform.position;
        //    SpriteRenderer spriteRenderer = go.GetComponent<SpriteRenderer>();
        //    spriteRenderer.sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f),1.0f);
        //}
    }

    public float speedX = 0;
    public float speedY = 0;
    float dt = 0;
    static GameObject prefab = null;
    static Texture2D tex = null;
    // Use this for initialization
    void Start()
    {
        prefab = Resources.Load("SpriteFrame") as GameObject;
        tex = Resources.Load("RectForAll") as Texture2D;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
