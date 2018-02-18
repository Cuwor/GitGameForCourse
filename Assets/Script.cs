using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{

    private Light a;
    void Start()
    {
        a = GetComponent<Light>();
    }
    
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space))
	    {
	       a.gameObject.SetActive(false);
	    }
	}
}
