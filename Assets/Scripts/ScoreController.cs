using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreController : MonoBehaviour {

    public Text scoreText;
    public Text winText;
    public int maxScore;
    private float score;
    private Data data;

    void Start () {
        score = 0;
        data = new Data();
        ShowScore();
        SafeScore();
    }

    public void IncreaseScore(int points) {
        score = score + points;
        ShowScore();
        SafeScore();
    }

    void ShowScore() {
        scoreText.text = "Score: " + score;
        if (score >= maxScore)
            winText.text = GameSettings.Instance.winMessage;
        else
            winText.text = "";
    }

    void SafeScore() {
        data.lastScore = score;
        DataPersistent.Save(data);
    }
}
