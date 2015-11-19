using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class PowerUp : Collectable {

    public int speedBonus;
    private GameObject player;

    void Start() {
        PlayerEntered += HandlePlayerEntered;
    }

    void HandlePlayerEntered()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (GameSettings.Instance.isFirstPersonGame) {
            FirstPersonController playerController = player.GetComponent<FirstPersonController>();
            playerController.ActiveSpeedBonus(speedBonus);
        } else {
            PlayerController playerController = player.GetComponent<PlayerController>();
            playerController.ActiveSpeedBonus(speedBonus);
        }
    }
  
}
