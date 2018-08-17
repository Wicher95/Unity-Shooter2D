using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {

    public Transform GameFinished;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider smth)
    {
        if (smth.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            GameFinished.gameObject.SetActive(true);
        }        
    }

}
