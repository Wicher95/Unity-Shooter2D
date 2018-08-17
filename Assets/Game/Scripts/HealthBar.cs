using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    private float fillAmount;
    public Image content;
	// Use this for initialization
	void Start () {
        fillAmount = 1f;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void Hapsy(float hapsy)
    {
        fillAmount -= hapsy;
        content.fillAmount = fillAmount;
    }
}
