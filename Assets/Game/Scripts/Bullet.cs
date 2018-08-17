using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed;

    public float lifetime;

    public GameObject explosion;
	// Use this for initialization
	void Start()
    { 

	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        lifetime -= Time.deltaTime;
        if (lifetime <= 0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision smth)
    {
        if(smth.gameObject.tag == "Enemy")
        {            
            smth.gameObject.GetComponent<EnemyHP>().Damage(1f);            
        }
        if(smth.gameObject.tag == "Player")
        {
            smth.gameObject.GetComponent<PlayerHP>().Damage(1f);
        }
        GameObject expl = Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(expl, 1);
    }
}
