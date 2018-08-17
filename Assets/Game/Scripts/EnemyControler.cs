using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour {

    public Rigidbody enemy;
    private Movment thePlayer;
    public Fire Gun1;
    //public float speed;

    // Use this for initialization
    void Start () {
        enemy = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<Movment>();
	}

    // Update is called once per frame
    void Update() {
        Vector3 playerPos = new Vector3(thePlayer.transform.position.x, thePlayer.transform.position.y, thePlayer.transform.position.z);
        Vector3 lookat = thePlayer.transform.position - transform.position;
        RaycastHit hit;
        //http://answers.unity3d.com/questions/894022/how-to-raycast-always-in-direction-of-a-object.html
        if (Physics.Raycast(transform.position, lookat, out hit))
        {
            
            if (hit.collider.tag == "Player")
            {
                transform.LookAt(playerPos);
                transform.Rotate(new Vector3(-90, 0, -90));
                Gun1.isFiring = true;
            }
            else
            {
                Gun1.isFiring = false;
            }
        }
        
    }
    /*private void FixedUpdate() // Odświeżanie z tą samą częstotliowścią
    {
        //enemy.velocity = (transform.forward * speed);
    }*/
}
