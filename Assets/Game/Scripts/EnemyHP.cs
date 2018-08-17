using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour {

    public float health;
    private float currentHelath;
    private Movment thePlayer;
	// Use this for initialization
	void Start () {
        currentHelath = health;
        thePlayer = FindObjectOfType<Movment>();
    }
	
	// Update is called once per frame
	void Update () {
		if(currentHelath <= 0f)
        {
            thePlayer.Score(100);
            Destroy(gameObject);
        }

        
	}
    public void Damage(float dmg)
    {
        currentHelath -= dmg;
    }
}
