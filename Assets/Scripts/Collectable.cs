using UnityEngine;
using System;
using System.Collections;

public class Collectable : MonoBehaviour {

    public int pointScore;
    private ScoreController score;

    public Action PlayerEntered {
        get;
        set;
    }

    void Start() {
        score = FindObjectOfType<ScoreController>();
    }
    
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            if(score)
                score.IncreaseScore(pointScore);

            if (PlayerEntered != null)
                PlayerEntered();

            //this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}
