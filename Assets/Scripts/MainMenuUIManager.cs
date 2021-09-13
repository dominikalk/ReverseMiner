using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIManager : MonoBehaviour {

    public Text HighScore;

	// Use this for initialization
	void Start () {
        FirstTime();
        HighScore.text = "Highscore: " + PlayerPrefs.GetInt("Highscore");
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void play()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void pickaxes()
    {
        SceneManager.LoadScene("InfoPage");
    }

    void FirstTime()
    {
        if (!PlayerPrefs.HasKey("Points"))
        {
            PlayerPrefs.SetInt("Points", 0);
        }

        if (!PlayerPrefs.HasKey("Discovered"))
        {
            PlayerPrefs.SetInt("Discovered", 0);
        }

        if (!PlayerPrefs.HasKey("AfterDiscovered"))
        {
            PlayerPrefs.SetInt("AfterDiscovered", 0);
        }

        if (!PlayerPrefs.HasKey("Element"))
        {
            PlayerPrefs.SetString("Element", "No");
        }

        if (!PlayerPrefs.HasKey("PickaxeLevel"))
        {
            PlayerPrefs.SetInt("PickaxeLevel", 1);
        }

        if (!PlayerPrefs.HasKey("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", 0);
        }

        if (!PlayerPrefs.HasKey("StonePick"))
        {
            PlayerPrefs.SetInt("StonePick", 0);
        }

        if (!PlayerPrefs.HasKey("IronPick"))
        {
            PlayerPrefs.SetInt("IronPick", 0);
        }

        if (!PlayerPrefs.HasKey("GoldPick"))
        {
            PlayerPrefs.SetInt("GoldPick", 0);
        }

        if (!PlayerPrefs.HasKey("EmeraldPick"))
        {
            PlayerPrefs.SetInt("EmeraldPick", 0);
        }

        if (!PlayerPrefs.HasKey("DiamondPick"))
        {
            PlayerPrefs.SetInt("DiamondPick", 0);
        }

        if (!PlayerPrefs.HasKey("VibraniumPick"))
        {
            PlayerPrefs.SetInt("VibraniumPick", 0);
        }

    }

}
