using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public GameObject firstPersonPlayer;
    public GameObject thirdPersonPlayer;

    void Start () {
        firstPersonPlayer.SetActive(GameSettings.Instance.isFirstPersonGame);
        thirdPersonPlayer.SetActive(!GameSettings.Instance.isFirstPersonGame);
    }
	
}
