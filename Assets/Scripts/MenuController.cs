using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	public void StartFirstPersonMaze()
    {
        GameSettings.Instance.isFirstPersonGame = true;
        Application.LoadLevel("cockies");
    }

    public void StartThirdPersonMaze()
    {
        GameSettings.Instance.isFirstPersonGame = false;
        Application.LoadLevel("cockies");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
