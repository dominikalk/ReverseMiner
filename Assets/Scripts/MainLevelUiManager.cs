using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainLevelUiManager : MonoBehaviour {

    // GameOver Variables

    public Text Dirt;
    public Text Wood;
    public Text Stone;
    public Text Coal;
    public Text Iron;
    public Text Silver;
    public Text Gold;
    public Text Emerald;
    public Text Diamond;
    public Text Vibranium;

    public Text ScoreGO;
    public Text HighScore;
    public Text PointsGO;

    public GameObject Miner;
    public GameObject MainUI;
    public GameObject GameOverPanel;
    public GameObject PickaxePick1;

    public GameObject WoodenPickaxeGO;
    public GameObject StonePickaxeGO;
    public GameObject IronPickaxeGO;
    public GameObject GoldPickaxeGO;
    public GameObject EmeraldPickaxeGO;
    public GameObject DiamondPickaxeGO;
    public GameObject VibraniumPickaxeGO;

    public Text PickaxeWordGO;

    // End Game Over Variables


    public GameObject WoodenPickaxe;
    public GameObject StonePickaxe;
    public GameObject IronPickaxe;
    public GameObject GoldPickaxe;
    public GameObject EmeraldPickaxe;
    public GameObject DiamondPickaxe;
    public GameObject VibraniumPickaxe;

    public Text UsingPickaxeText;
    public Text StrengthText;
    string PickaxeWord;
    public Text Points;
    public Text Score;
    public GameObject PressToStart;

    public GameObject DiscoveryPanel;
    public GameObject DiscoveryOKPanel;
    public InputField InputField;
    string ElementName;
    public Text ReplaceConfirmation;

    // Use this for initialization
    void Start() {
        pickaxePic();
        pickaxeWordFun();
        UsingPickaxeText.text = "Using: " + PickaxeWord + " Pickaxe";
        StrengthText.text = "Strength: " + PlayerPrefs.GetInt("PickaxeLevel") + "/7";
    }

    // Update is called once per frame
    void Update() {
        Points.text = "Points: " + PlayerPrefs.GetInt("Points").ToString();
        Score.text = "Score: " + GameManager.instance.score;
        Discovery();

        if (GameManager.instance.started == true)
        {
            PressToStart.SetActive(false);
        }

        if (GameManager.instance.dead == true)
        {
            GameOverPanelFun();
        }
    }

    void pickaxeWordFun()
    {
        if (PlayerPrefs.GetInt("PickaxeLevel") == 1)
        {
            PickaxeWord = "Wooden";
        }

        if (PlayerPrefs.GetInt("PickaxeLevel") == 2)
        {
            PickaxeWord = "Stone";
        }

        if (PlayerPrefs.GetInt("PickaxeLevel") == 3)
        {
            PickaxeWord = "Iron";
        }

        if (PlayerPrefs.GetInt("PickaxeLevel") == 4)
        {
            PickaxeWord = "Golden";
        }

        if (PlayerPrefs.GetInt("PickaxeLevel") == 5)
        {
            PickaxeWord = "Emerald";
        }

        if (PlayerPrefs.GetInt("PickaxeLevel") == 6)
        {
            PickaxeWord = "Diamond";
        }

        if (PlayerPrefs.GetInt("PickaxeLevel") == 7)
        {
            PickaxeWord = "Vibranium";
        }
    }

    void pickaxePic()
    {
        if (PlayerPrefs.GetInt("PickaxeLevel") == 1)
        {
            WoodenPickaxe.SetActive(true);
            StonePickaxe.SetActive(false);
            IronPickaxe.SetActive(false);
            GoldPickaxe.SetActive(false);
            EmeraldPickaxe.SetActive(false);
            DiamondPickaxe.SetActive(false);
            VibraniumPickaxe.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PickaxeLevel") == 2)
        {
            WoodenPickaxe.SetActive(false);
            StonePickaxe.SetActive(true);
            IronPickaxe.SetActive(false);
            GoldPickaxe.SetActive(false);
            EmeraldPickaxe.SetActive(false);
            DiamondPickaxe.SetActive(false);
            VibraniumPickaxe.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PickaxeLevel") == 3)
        {
            WoodenPickaxe.SetActive(false);
            StonePickaxe.SetActive(false);
            IronPickaxe.SetActive(true);
            GoldPickaxe.SetActive(false);
            EmeraldPickaxe.SetActive(false);
            DiamondPickaxe.SetActive(false);
            VibraniumPickaxe.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PickaxeLevel") == 4)
        {
            WoodenPickaxe.SetActive(false);
            StonePickaxe.SetActive(false);
            IronPickaxe.SetActive(false);
            GoldPickaxe.SetActive(true);
            EmeraldPickaxe.SetActive(false);
            DiamondPickaxe.SetActive(false);
            VibraniumPickaxe.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PickaxeLevel") == 5)
        {
            WoodenPickaxe.SetActive(false);
            StonePickaxe.SetActive(false);
            IronPickaxe.SetActive(false);
            GoldPickaxe.SetActive(false);
            EmeraldPickaxe.SetActive(true);
            DiamondPickaxe.SetActive(false);
            VibraniumPickaxe.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PickaxeLevel") == 6)
        {
            WoodenPickaxe.SetActive(false);
            StonePickaxe.SetActive(false);
            IronPickaxe.SetActive(false);
            GoldPickaxe.SetActive(false);
            EmeraldPickaxe.SetActive(false);
            DiamondPickaxe.SetActive(true);
            VibraniumPickaxe.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PickaxeLevel") == 7)
        {
            WoodenPickaxe.SetActive(false);
            StonePickaxe.SetActive(false);
            IronPickaxe.SetActive(false);
            GoldPickaxe.SetActive(false);
            EmeraldPickaxe.SetActive(false);
            DiamondPickaxe.SetActive(false);
            VibraniumPickaxe.SetActive(true);
        }
    }

    public void menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void retry()
    {
        GameManager.instance.dead = false;
        Miner.SetActive(true);
        MainUI.SetActive(true);
        GameOverPanel.SetActive(false);
        PickaxePick1.SetActive(true);
        PressToStart.SetActive(true);
        Miner.transform.position = new Vector3(-5.8f, -4.4f);
        GameManager.instance.score = 0;
        GameManager.instance.TimePlaying = Time.time;

        BlockSpawner.instance.CancelInvoke("IncreaseScore");
        BlockSpawner.instance.RepeatingScore = false;

        GameManager.instance.DBD = 0;
        GameManager.instance.WBD = 0;
        GameManager.instance.SBD = 0;
        GameManager.instance.CBD = 0;
        GameManager.instance.IBD = 0;
        GameManager.instance.SiBD = 0;
        GameManager.instance.GBD = 0;
        GameManager.instance.EBD = 0;
        GameManager.instance.DiBD = 0;
        GameManager.instance.VBD = 0;

        GameManager.instance.started = false;

        if (GameManager.instance.score > PlayerPrefs.GetInt("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", GameManager.instance.score);
        }
    }

    void GameOverPanelFun()
    {
        MainUI.SetActive(false);
        Miner.SetActive(false);
        GameOverPanel.SetActive(true);
        PickaxePick1.SetActive(false);

        PointsGO.text = "Points: " + PlayerPrefs.GetInt("Points").ToString();
        ScoreGO.text = "Score: " + GameManager.instance.score;
        HighScore.text = "High Score: " + PlayerPrefs.GetInt("Highscore");

        Dirt.text = GameManager.instance.DBD.ToString();
        Wood.text = GameManager.instance.WBD.ToString();
        Stone.text = GameManager.instance.SBD.ToString();
        Coal.text = GameManager.instance.CBD.ToString();
        Iron.text = GameManager.instance.IBD.ToString();
        Silver.text = GameManager.instance.SiBD.ToString();
        Gold.text = GameManager.instance.GBD.ToString();
        Emerald.text = GameManager.instance.EBD.ToString();
        Diamond.text = GameManager.instance.DiBD.ToString();
        Vibranium.text = GameManager.instance.VBD.ToString();

        PickaxeWordGO.text = PickaxeWord + " Pickaxe";

        GOPickaxes();
    }

    void GOPickaxes()
    {
        if (PlayerPrefs.GetInt("PickaxeLevel") == 1)
        {
            WoodenPickaxeGO.SetActive(true);
            StonePickaxeGO.SetActive(false);
            IronPickaxeGO.SetActive(false);
            GoldPickaxeGO.SetActive(false);
            EmeraldPickaxeGO.SetActive(false);
            DiamondPickaxeGO.SetActive(false);
            VibraniumPickaxeGO.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PickaxeLevel") == 2)
        {
            WoodenPickaxeGO.SetActive(false);
            StonePickaxeGO.SetActive(true);
            IronPickaxeGO.SetActive(false);
            GoldPickaxeGO.SetActive(false);
            EmeraldPickaxeGO.SetActive(false);
            DiamondPickaxeGO.SetActive(false);
            VibraniumPickaxeGO.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PickaxeLevel") == 3)
        {
            WoodenPickaxeGO.SetActive(false);
            StonePickaxeGO.SetActive(false);
            IronPickaxeGO.SetActive(true);
            GoldPickaxeGO.SetActive(false);
            EmeraldPickaxeGO.SetActive(false);
            DiamondPickaxeGO.SetActive(false);
            VibraniumPickaxeGO.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PickaxeLevel") == 4)
        {
            WoodenPickaxeGO.SetActive(false);
            StonePickaxeGO.SetActive(false);
            IronPickaxeGO.SetActive(false);
            GoldPickaxeGO.SetActive(true);
            EmeraldPickaxeGO.SetActive(false);
            DiamondPickaxeGO.SetActive(false);
            VibraniumPickaxeGO.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PickaxeLevel") == 5)
        {
            WoodenPickaxeGO.SetActive(false);
            StonePickaxeGO.SetActive(false);
            IronPickaxeGO.SetActive(false);
            GoldPickaxeGO.SetActive(false);
            EmeraldPickaxeGO.SetActive(true);
            DiamondPickaxeGO.SetActive(false);
            VibraniumPickaxeGO.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PickaxeLevel") == 6)
        {
            WoodenPickaxeGO.SetActive(false);
            StonePickaxeGO.SetActive(false);
            IronPickaxeGO.SetActive(false);
            GoldPickaxeGO.SetActive(false);
            EmeraldPickaxeGO.SetActive(false);
            DiamondPickaxeGO.SetActive(true);
            VibraniumPickaxeGO.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PickaxeLevel") == 7)
        {
            WoodenPickaxeGO.SetActive(false);
            StonePickaxeGO.SetActive(false);
            IronPickaxeGO.SetActive(false);
            GoldPickaxeGO.SetActive(false);
            EmeraldPickaxeGO.SetActive(false);
            DiamondPickaxeGO.SetActive(false);
            VibraniumPickaxeGO.SetActive(true);
        }
    }

    void Discovery()
    {
        if (PlayerPrefs.GetInt("Discovered") == 1 && PlayerPrefs.GetInt("AfterDiscovered") == 0)
        {
            DiscoveryPanel.SetActive(true);
        }
    }

    public void entered()
    {
        PlayerPrefs.SetInt("AfterDiscovered", 1);
        PlayerPrefs.SetString("Element", InputField.text.ToString());
        DiscoveryOKPanel.SetActive(true);
        ReplaceConfirmation.text = "The new element has been called " + PlayerPrefs.GetString("Element") + ". \nBut you do not have a strong enough pickaxe to break it so just try to avoid them in the future.";
        DiscoveryPanel.SetActive(false);
    }

    public void DiscoveryOK()
    {
        DiscoveryOKPanel.SetActive(false);
        GameManager.instance.dead = true;
    }
}
