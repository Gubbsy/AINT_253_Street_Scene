using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.visible = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (Cursor.visible != true)
            Cursor.visible = true;
	}

    public void PlayPressed()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitPressed() {
        Application.Quit();
    }
}
