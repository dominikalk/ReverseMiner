using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour {

    public int BlockHardness;
    public int BlockPoints;
    public GameObject BlockName;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Remover")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Miner")
        {
            if (PlayerPrefs.GetInt("PickaxeLevel") >= BlockHardness)
            {
                PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") + BlockPoints);
                blockDestroy();
                Destroy(gameObject);
            }

            else
            {
                if (PlayerPrefs.GetInt("AfterDiscovered") == 0)
                {
                    Element0();
                }
                if (PlayerPrefs.GetInt("Discovered") == 0 || PlayerPrefs.GetInt("AfterDiscovered") == 1) 
                {
                    GameManager.instance.dead = true;
                }
            }
        }
    }

    void blockDestroy()
    {
        if (BlockName.tag == "Dirt")
        {
            GameManager.instance.DBD += 1;
        }

        if (BlockName.tag == "Wood")
        {
            GameManager.instance.WBD += 1;
        }

        if (BlockName.tag == "Stone")
        {
            GameManager.instance.SBD += 1;
        }

        if (BlockName.tag == "Coal")
        {
            GameManager.instance.CBD += 1;
        }

        if (BlockName.tag == "Iron")
        {
            GameManager.instance.IBD += 1;
        }

        if (BlockName.tag == "Silver")
        {
            GameManager.instance.SiBD += 1;
        }

        if (BlockName.tag == "Gold")
        {
            GameManager.instance.GBD += 1;
        }

        if (BlockName.tag == "Emerald")
        {
            GameManager.instance.EBD += 1;
        }

        if (BlockName.tag == "Diamond")
        {
            GameManager.instance.DiBD += 1;
        }

        if (BlockName.tag == "Vibranium")
        {
            GameManager.instance.VBD += 1;
        }
    }

    void Element0()
    {
        if (BlockHardness == 8)
        {
            PlayerPrefs.SetInt("Discovered", 1);
        }
    }
}
