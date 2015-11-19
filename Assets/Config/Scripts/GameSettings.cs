using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class GameSettings : ScriptableObject {
	public const string ASSET_NAME = "GameSettings";

    public bool isFirstPersonGame;
    public string winMessage;

	private static GameSettings instance; 
	
	public static GameSettings Instance {
		get	{
			if (instance == null)	{
				instance = Resources.Load (ASSET_NAME) as GameSettings;
			}			
			
			return instance;
		}
	}
}
