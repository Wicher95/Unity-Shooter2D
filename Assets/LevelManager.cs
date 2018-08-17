using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public Transform Pause;
    public Texture2D cursorTxt;

    public void StartGame(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Resume()
    {
        Time.timeScale = 1f;
        Cursor.SetCursor(cursorTxt, Vector2.zero, CursorMode.Auto);
        Pause.gameObject.SetActive(false);
    }
}
