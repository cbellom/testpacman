using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LastScoreController : MonoBehaviour {

    public Text lastScoreText;

	void Start () {
        lastScoreText.text = "";
        LoadLastScore();
    }

    void LoadLastScore() {
        DataPersistent.Load();
        lastScoreText.text = "Your last score was : " + DataPersistent.data.lastScore;
    }
	
}
