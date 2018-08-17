using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour {

    public Rigidbody player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {        
        transform.position = new Vector3(player.position.x, 20, player.position.z);
    }
}
