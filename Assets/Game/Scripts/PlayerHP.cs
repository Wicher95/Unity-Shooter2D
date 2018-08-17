using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour {

    public float health;
    private float currentHelath;
    public float flashlenght;
    private float flashcounter;

    public Transform YouDied;    
    public Renderer rend;
    private HealthBar hapsy;
    private Material[] mat = new Material[4];
    private Color[] color = new Color[4];    
    // Use this for initialization
    void Start()
    {
        YouDied.gameObject.SetActive(false);        
        hapsy = FindObjectOfType<HealthBar>();
        currentHelath = health;
        rend = GetComponent<Renderer>();
        mat = rend.materials;
        for (int i=0;i<4;i++)
        {            
            color[i] = mat[i].GetColor("_Color");
        }
        //color = rend.material.GetColor("_Color");

    }

    // Update is called once per frame
    void Update()
    {
        if (currentHelath <= 0f)
        {
            Time.timeScale = 0;
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            gameObject.SetActive(false);
            YouDied.gameObject.SetActive(true);
            //SceneManager.LoadScene("Scena");
        }
        if (flashcounter > 0)
        {
            flashcounter -= Time.deltaTime;
            if (flashcounter <= 0)
            {
                for(int i=0;i<4;i++)
                {
                    mat[i].SetColor("_Color", color[i]);                    
                }
                //rend.material.SetColor("_Color", color);               
            }
        }

    }
    public void Damage(float dmg)
    {
        hapsy.Hapsy(0.1f);
        currentHelath -= dmg;
        flashcounter = flashlenght;
        for (int i = 0; i < 4; i++)
        {
            mat[i].SetColor("_Color", Color.red);
        }
            //rend.material.SetColor("_Color", Color.red);    
    }
}
