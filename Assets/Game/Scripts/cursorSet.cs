using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorSet : MonoBehaviour {

    public Texture2D cursorTxt;
    // Use this for initialization
    void Start()
    {
        Cursor.SetCursor(cursorTxt,Vector2.zero,CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
