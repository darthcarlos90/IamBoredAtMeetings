

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControllerScript: MonoBehaviour {

    public float MovementValue = 0.01f;
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(transform.position);
        Vector3 newPosition = new Vector3();
        bool keypressed = false;
        if (Input.GetKey(KeyCode.W))
        {
            newPosition = transform.position + new Vector3(0, 0, MovementValue);
            keypressed = true;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            newPosition = transform.position + new Vector3(0, 0, -MovementValue);
            keypressed = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            newPosition = transform.position + new Vector3(MovementValue, 0, 0);
            keypressed = true;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            newPosition = transform.position + new Vector3(-MovementValue, 0, 0);
            keypressed = true;
        } 

        if (keypressed)
        {
            bool value = agent.SetDestination(newPosition);
            Debug.Log(" The result is valuable " + value);
        }
    }
}
