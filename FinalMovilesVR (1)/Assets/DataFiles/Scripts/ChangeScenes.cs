using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScenes : MonoBehaviour {
	public static int currentLevel = 1;

    public Text currentTime;
	public void LoadDayScene () {
		SceneManager.LoadScene ("DayScene");
	}

	public void LoadNightScene () {
		SceneManager.LoadScene ("NightScene");
	}
    void Update()
    {
        //currentTime.text = System.DateTime.Now.Hour.ToString("00");
		string ObjectName = PlayerPrefs.GetString("NameButton");
		if (Input.GetKeyDown ("joystick button 0"))
		{
			if (ObjectName == "RawImage1") // Load Scene
			{
				QuitGame ();
			}
			else if (ObjectName == "RawImage2") // Quit
			{
				LoadSceneAuto ();
			}
		}
    }
    public void LoadSceneAuto()
    {
		print ("YARA MANO : ");
		print (ChangeScenes.currentLevel);
        int hora = System.DateTime.Now.Hour;
        if (hora > 18 || hora <4 )
            SceneManager.LoadScene("NightScene");
        else
            SceneManager.LoadScene("DayScene");

    }

    public void QuitGame () {
		Application.Quit ();
		Debug.Log ("Quit Game!");
	}
}
