using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plot : MonoBehaviour {
    public bool HasTower;
    public GameObject Tower;
    private Vector3 _position;
	// Use this for initialization
	void Start () {
        _position = gameObject.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        print("You clicked Plot " +  _position.x + ", " + _position.z);
        if (!HasTower)
        {
            HasTower = true;
            var towerPosition = _position;
            towerPosition.y++;
            Instantiate(Tower, towerPosition, Quaternion.identity);
        }
    }

}
