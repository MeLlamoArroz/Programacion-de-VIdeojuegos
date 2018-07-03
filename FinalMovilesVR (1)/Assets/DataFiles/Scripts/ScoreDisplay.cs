using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

	Mcalculator mcalc;
	int monsterCount = 0;
	public Text monsterText;
    public Text failText;
    public Text successsText;

    void Start () {
		mcalc = FindObjectOfType<Mcalculator> ();
		monsterCount = mcalc.counter;
        if (monsterCount >= 5)
        {
            ChangeScenes.currentLevel += 1;
            print("äsdasd");
            successsText.text = "Pasaste al nivel "+ ChangeScenes.currentLevel;
            successsText.enabled = true;
            failText.enabled = false;
        }
        else
        {
            print("dsadsadsa");
            failText.text = "Fallaste";
            successsText.enabled = false;
            failText.enabled = true;
        }
        monsterText.text = monsterCount.ToString ();
		Destroy (mcalc.gameObject);
	}
}
