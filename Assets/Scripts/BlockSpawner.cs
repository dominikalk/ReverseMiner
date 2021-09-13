using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {

    public static BlockSpawner instance;

    public GameObject Dirt;
    public GameObject Wood;
    public GameObject Stone;
    public GameObject Coal;
    public GameObject Iron;
    public GameObject Silver;
    public GameObject Gold;
    public GameObject Emerald;
    public GameObject Diamond;
    public GameObject Vibranium;
    public GameObject Element0;


    int randomPositionNo;
    float randomPosition;
    int randomBlockNo;
    GameObject randomBlock;
    int YesNo;
    public int probability;

    float position1;
    float position2;
    float position3;
    float position4;
    float position5;
    float position6;
    float position7;
    float position8;
    float position9;

    public bool RepeatingScore;
    bool TimePlayingCalled;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    // Use this for initialization
    void Start () {
        position1 = -7.1f;
        position2 = -5.35f;
        position3 = -3.6f;
        position4 = -1.85f;
        position5 = -0.1f;
        position6 = 1.65f;
        position7 = 3.4f;
        position8 = 5.15f;
        position9 = 6.9f;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            GameManager.instance.started = true;
            probability = 20;
        }

        if (GameManager.instance.started == true && GameManager.instance.dead != true)
        {
            spawn();
            TimePlayingFun();
            if (RepeatingScore == false)
            {
                RepeatingScore = true;
                InvokeRepeating("IncreaseScore", 0f, 0.5f);
                GameManager.instance.TimePlaying = Time.time;
            }
        }

        if (GameManager.instance.dead == true)
        {
            if (GameManager.instance.score > PlayerPrefs.GetInt("Highscore")) 
            {
                PlayerPrefs.SetInt("Highscore", GameManager.instance.score);
            }

            CancelInvoke("IncreaseScore");
        }
    }

    void TimePlayingFun()
    {
        if(TimePlayingCalled != true)
        {
            GameManager.instance.TimePlaying = Time.time;
            TimePlayingCalled = true;
        }
    }

    void IncreaseScore()
    {
        GameManager.instance.score += 1;
    }

    void spawn()
    {
        randomPositionNo = Random.Range(1, 10);
        YesNo = Random.Range(0, probability);

        if (randomPositionNo == 1)
        {
            randomPosition = position1;
        }

        else if (randomPositionNo == 2)
        {
            randomPosition = position2;
        }

        else if (randomPositionNo == 3)
        {
            randomPosition = position3;
        }

        else if (randomPositionNo == 4)
        {
            randomPosition = position4;
        }

        else if (randomPositionNo == 5)
        {
            randomPosition = position5;
        }

        else if (randomPositionNo == 6)
        {
            randomPosition = position6;
        }

        else if (randomPositionNo == 7)
        {
            randomPosition = position7;
        }

        else if (randomPositionNo == 8)
        {
            randomPosition = position8;
        }

        else if (randomPositionNo == 9)
        {
            randomPosition = position9;
        }

        if (randomBlockNo == 1)
        {
            randomBlock = Dirt;
        }

        if (YesNo == 1)
        {
            if (Time.time - GameManager.instance.TimePlaying < 10)
            {
                Instantiate(Dirt, new Vector3(randomPosition, 8), Quaternion.identity);
            }

            else if (Time.time - GameManager.instance.TimePlaying < 20)
            {
                randomBlockNo = Random.Range(1, 3);
                RandBlock();
                Instantiate(randomBlock, new Vector3(randomPosition, 8), Quaternion.identity);
            }

            else if (Time.time - GameManager.instance.TimePlaying < 30)
            {
                randomBlockNo = Random.Range(1, 4);
                RandBlock();
                Instantiate(randomBlock, new Vector3(randomPosition, 8), Quaternion.identity);
            }

            else if (Time.time - GameManager.instance.TimePlaying < 40)
            {
                randomBlockNo = Random.Range(1, 5);
                RandBlock();
                Instantiate(randomBlock, new Vector3(randomPosition, 8), Quaternion.identity);
            }

            else if (Time.time - GameManager.instance.TimePlaying < 50)
            {
                randomBlockNo = Random.Range(1, 6);
                RandBlock();
                Instantiate(randomBlock, new Vector3(randomPosition, 8), Quaternion.identity);
            }

            else if (Time.time - GameManager.instance.TimePlaying < 60)
            {
                randomBlockNo = Random.Range(1, 7);
                RandBlock();
                Instantiate(randomBlock, new Vector3(randomPosition, 8), Quaternion.identity);
            }

            else if (Time.time - GameManager.instance.TimePlaying < 70)
            {
                randomBlockNo = Random.Range(2, 8);
                RandBlock();
                Instantiate(randomBlock, new Vector3(randomPosition, 8), Quaternion.identity);
            }

            else if (Time.time - GameManager.instance.TimePlaying < 80)
            {
                randomBlockNo = Random.Range(3, 9);
                RandBlock();
                Instantiate(randomBlock, new Vector3(randomPosition, 8), Quaternion.identity);
            }

            else if (Time.time - GameManager.instance.TimePlaying < 90)
            {
                randomBlockNo = Random.Range(4, 9);
                RandBlock();
                Instantiate(randomBlock, new Vector3(randomPosition, 8), Quaternion.identity);
            }

            else if (Time.time - GameManager.instance.TimePlaying < 100)
            {
                randomBlockNo = Random.Range(5, 9);
                RandBlock();
                Instantiate(randomBlock, new Vector3(randomPosition, 8), Quaternion.identity);
            }

            else if (Time.time - GameManager.instance.TimePlaying < 110)
            {
                randomBlockNo = Random.Range(6, 10);
                RandBlock();
                Instantiate(randomBlock, new Vector3(randomPosition, 8), Quaternion.identity);
            }

            else if (Time.time - GameManager.instance.TimePlaying < 120)
            {
                randomBlockNo = Random.Range(7, 10);
                RandBlock();
                Instantiate(randomBlock, new Vector3(randomPosition, 8), Quaternion.identity);
            }

            else if (Time.time - GameManager.instance.TimePlaying < 130)
            {
                randomBlockNo = Random.Range(8, 11);
                RandBlock();
                Instantiate(randomBlock, new Vector3(randomPosition, 8), Quaternion.identity);
            }

            else if (Time.time - GameManager.instance.TimePlaying >= 130)
            {
                randomBlockNo = Random.Range(8, 12);
                RandBlock();
                Instantiate(randomBlock, new Vector3(randomPosition, 8), Quaternion.identity);
                if (probability > 5)
                {
                    InvokeRepeating("Harder", 0.1f, 2);
                }
            }
        }
    }

    void RandBlock()
    {
        if (randomBlockNo == 1)
        {
            randomBlock = Dirt;
        }

        else if (randomBlockNo == 2)
        {
            randomBlock = Wood;
        }

        else if (randomBlockNo == 3)
        {
            randomBlock = Stone;
        }

        else if (randomBlockNo == 4)
        {
            randomBlock = Coal;
        }

        else if (randomBlockNo == 5)
        {
            randomBlock = Iron;
        }

        else if (randomBlockNo == 6)
        {
            randomBlock = Silver;
        }

        else if (randomBlockNo == 7)
        {
            randomBlock = Gold;
        }

        else if (randomBlockNo == 8)
        {
            randomBlock = Emerald;
        }

        else if (randomBlockNo == 9)
        {
            randomBlock = Diamond;
        }

        else if (randomBlockNo == 10)
        {
            randomBlock = Vibranium;
        }

        else if (randomBlockNo == 11)
        {
            randomBlock = Element0;
        }
    }

    void Harder()
    {
        if (probability >= 5)
        {
            probability -= 1;
        }

        else
        {
            CancelInvoke("Harder");
        }
    }
}
