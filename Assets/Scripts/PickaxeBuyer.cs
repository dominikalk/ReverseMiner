using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickaxeBuyer : MonoBehaviour {

    public GameObject StoneButton;
    public GameObject StoneBought;
    public GameObject IronButton;
    public GameObject IronBought;
    public GameObject GoldButton;
    public GameObject GoldBought;
    public GameObject EmeraldButton;
    public GameObject EmeraldBought;
    public GameObject DiamondButton;
    public GameObject DiamondBought;
    public GameObject VibraniumButton;
    public GameObject VibraniumBought;

    public GameObject NoMoneyPanel;

    public Text Points;
    public GameObject ResetPanel;
    public GameObject ResetOKPanel;

    // Use this for initialization
    void Start () {
        BuyButtonActive();
    }
	
	// Update is called once per frame
	void Update () {
        Points.text = "Points: " + PlayerPrefs.GetInt("Points").ToString();
	}

    void BuyButtonActive()
    {
        if (PlayerPrefs.GetInt("StonePick") == 1)
        {
            StoneButton.SetActive(false);
            StoneBought.SetActive(true);
        }

        if (PlayerPrefs.GetInt("IronPick") == 1)
        {
            IronButton.SetActive(false);
            IronBought.SetActive(true);
        }

        if (PlayerPrefs.GetInt("GoldPick") == 1)
        {
            GoldButton.SetActive(false);
            GoldBought.SetActive(true);
        }

        if (PlayerPrefs.GetInt("EmeraldPick") == 1)
        {
            EmeraldButton.SetActive(false);
            EmeraldBought.SetActive(true);
        }

        if (PlayerPrefs.GetInt("DiamondPick") == 1)
        {
            DiamondButton.SetActive(false);
            DiamondBought.SetActive(true);
        }

        if (PlayerPrefs.GetInt("VibraniumPick") == 1)
        {
            VibraniumButton.SetActive(false);
            VibraniumBought.SetActive(true);
        }
    }



    public void BuyStone()
    {
        if (PlayerPrefs.GetInt("Points") >= 100)
        {
            PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") - 100);
            PlayerPrefs.SetInt("StonePick", 1);
            StoneButton.SetActive(false);
            StoneBought.SetActive(true);
            if (PlayerPrefs.GetInt("PickaxeLevel") < 2)
            {
                PlayerPrefs.SetInt("PickaxeLevel", 2);
            }
        }

        else
        {
            NoMoneyPanel.SetActive(true);
        }
    }

    public void BuyIron()
    {
        if (PlayerPrefs.GetInt("Points") >= 500)
        {
            PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") - 500);
            PlayerPrefs.SetInt("IronPick", 1);
            IronButton.SetActive(false);
            IronBought.SetActive(true);
            if (PlayerPrefs.GetInt("PickaxeLevel") < 3)
            {
                PlayerPrefs.SetInt("PickaxeLevel", 3);
            }
        }

        else
        {
            NoMoneyPanel.SetActive(true);
        }
    }

    public void BuyGold()
    {
        if (PlayerPrefs.GetInt("Points") >= 2000)
        {
            PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") - 2000);
            PlayerPrefs.SetInt("GoldPick", 1);
            GoldButton.SetActive(false);
            GoldBought.SetActive(true);
            if (PlayerPrefs.GetInt("PickaxeLevel") < 4)
            {
                PlayerPrefs.SetInt("PickaxeLevel", 4);
            }
        }

        else
        {
            NoMoneyPanel.SetActive(true);
        }
    }

    public void BuyEmerald()
    {
        if (PlayerPrefs.GetInt("Points") >= 5000)
        {
            PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") - 5000);
            PlayerPrefs.SetInt("EmeraldPick", 1);
            EmeraldButton.SetActive(false);
            EmeraldBought.SetActive(true);
            if (PlayerPrefs.GetInt("PickaxeLevel") < 5)
            {
                PlayerPrefs.SetInt("PickaxeLevel", 5);
            }
        }

        else
        {
            NoMoneyPanel.SetActive(true);
        }
    }

    public void BuyDiamond()
    {
        if (PlayerPrefs.GetInt("Points") >= 10000)
        {
            PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") - 10000);
            PlayerPrefs.SetInt("DiamondPick", 1);
            DiamondButton.SetActive(false);
            DiamondBought.SetActive(true);
            if (PlayerPrefs.GetInt("PickaxeLevel") < 6)
            {
                PlayerPrefs.SetInt("PickaxeLevel", 6);
            }
        }

        else
        {
            NoMoneyPanel.SetActive(true);
        }
    }

    public void BuyVibranium()
    {
        if (PlayerPrefs.GetInt("Points") >= 30000)
        {
            PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") - 30000);
            PlayerPrefs.SetInt("VibraniumPick", 1);
            VibraniumButton.SetActive(false);
            VibraniumBought.SetActive(true);
            if (PlayerPrefs.GetInt("PickaxLevel") < 7)
            {
                PlayerPrefs.SetInt("PickaxeLevel", 7);
            }
        }

        else
        {
            NoMoneyPanel.SetActive(true);
        }
    }

    public void NoMoneyOk()
    {
        NoMoneyPanel.SetActive(false);
    }

    public void menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ResetButton()
    {
        ResetPanel.SetActive(true);
    }

    public void ResetYes()
    {
        PlayerPrefs.SetInt("Points", 0);
        PlayerPrefs.SetInt("PickaxeLevel", 1);
        PlayerPrefs.SetInt("StonePick", 0);
        PlayerPrefs.SetInt("IronPick", 0);
        PlayerPrefs.SetInt("GoldPick", 0);
        PlayerPrefs.SetInt("EmeraldPick", 0);
        PlayerPrefs.SetInt("DiamondPick", 0);
        PlayerPrefs.SetInt("VibraniumPick", 0);
        PlayerPrefs.SetInt("Highscore", 0);
        PlayerPrefs.SetInt("Discovered", 0);
        PlayerPrefs.SetInt("AfterDiscovered", 0);
        ResetPanel.SetActive(false);
        ResetOKPanel.SetActive(true);
    }

    public void ResetNo()
    {
        ResetPanel.SetActive(false);
    }

    public void ResetOK()
    {
        ResetOKPanel.SetActive(false);
        BuyButtonActive();
    }
}
