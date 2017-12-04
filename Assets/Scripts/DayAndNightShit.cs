using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayAndNightShit : MonoBehaviour {


    private const float LIMIT_VALUE = 1600.0f;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0.03125f, 0, 0));
        if (transform.position.x >= LIMIT_VALUE) transform.Translate(new Vector3(-LIMIT_VALUE, 0, 0));
	}
}
