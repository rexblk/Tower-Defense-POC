using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobBehavior : MonoBehaviour {
    public Transform DestinationPoint;
	// Use this for initialization
	void Start () {
        var meshAgent = transform.GetComponent<UnityEngine.AI.NavMeshAgent>();
        meshAgent.destination = DestinationPoint.position;
        meshAgent.autoRepath = true;
    }
	
	// Update is called once per frame
	void Update () {
    }
}
