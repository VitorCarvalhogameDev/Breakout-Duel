using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmSwingDetectorActivator : MonoBehaviour {
    Collider col;

    public float ReActivateTime;

	// Use this for initialization
	void Start () {
        col = GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(!col.enabled)
        {
            ReActivateTime -= Time.deltaTime;
            if(ReActivateTime <= 0.0f)
            {
                col.enabled = true;
            }
        }
        else
        {
            ReActivateTime = 0.2f;
        }
	}
}
