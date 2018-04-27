using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobBehavior : MonoBehaviour {
    public Transform DestinationPoint;
	// Use this for initialization
	void Start () {
        transform.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = DestinationPoint.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
