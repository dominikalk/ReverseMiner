using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public bool dead;
    public int score;
    public bool started;
    public float TimePlaying;

    public bool Named;
    public bool NextGo;

    public int DBD;
    public int WBD;
    public int SBD;
    public int CBD;
    public int IBD;
    public int SiBD;
    public int GBD;
    public int EBD;
    public int DiBD;
    public int VBD;

    public bool Discovered;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

    }
}
