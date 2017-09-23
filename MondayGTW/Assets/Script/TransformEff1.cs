using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformEff1 : MonoBehaviour {
    float sclFactor = 0;
    bool getSmall = false;
    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        transform.position += new Vector3(0,0,1);
        if(!getSmall)
        {
            sclFactor += Time.deltaTime * 10;
            if (sclFactor > 1.5)
            {
                getSmall = true;
            }
        }
        else
        {
            sclFactor -= Time.deltaTime * 10;
        }

        if (sclFactor < -0.95f)
        {
            GameObject.Destroy(transform.gameObject);
        }
        else
        {
            float scale = 1 + sclFactor;
            transform.localScale = new Vector3(scale, scale, 1);
        }
    }
}
