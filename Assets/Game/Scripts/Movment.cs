using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movment : MonoBehaviour {

    public Rigidbody rigidBody;
    private float Speed;
    private int score;
    private bool slowmo;

    public Transform Pause;
    public Fire Gun1;
    public Text scoreText;
    private Vector3 move;
    private Vector3 moveVelocity;
    private Camera kamera;
    // Use this for initialization
    void Start () {
        Pause.gameObject.SetActive(false);
        //Cursor.visible = false;
        Time.timeScale = 1f;
        Speed = 4.5f;
        kamera = FindObjectOfType<Camera>();
        score = 0;
        slowmo = false;
    }
	
	// Update is called once per frame
	void Update () // Odświeżany z każdą klatką
    {                
        scoreText.text = "Score:  " + score.ToString();
        move = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        moveVelocity = move * Speed;

        Ray cameraRay = kamera.ScreenPointToRay(Input.mousePosition);
        Plane ground = new Plane(Vector3.up, Vector3.zero);
        float rayLength;

        if(ground.Raycast(cameraRay,out rayLength))
        {
             
            Vector3 pointtolook = cameraRay.GetPoint(rayLength);

            transform.LookAt(new Vector3(pointtolook.x,transform.position.y,pointtolook.z));

            transform.Rotate(new Vector3(-90, 0, -90));
        }



        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            Gun1.isFiring = true;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0) || Input.GetKeyUp(KeyCode.Space))
        {
            Gun1.isFiring = false;
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            Pause.gameObject.SetActive(true);
        }

        //Haxy
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (slowmo == false)
            {
                Time.timeScale = 0.5f;
                slowmo = true;
            }
            else if (slowmo == true)
            {
                Time.timeScale = 1f;
                slowmo = false;
            }
        }

    }
    private void FixedUpdate() // Odświeżanie z tą samą częstotliowścią
    {
        rigidBody.velocity = moveVelocity;        
    }
    public void Score(int points)
    {
        score += points;
    }
}
