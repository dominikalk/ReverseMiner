using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinerController : MonoBehaviour {

    Rigidbody2D rb;
    Animator anim;
    public float speed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if (PlayerPrefs.GetInt("Discovered") == 1 && PlayerPrefs.GetInt("AfterDiscovered") != 1)
        {
            gameObject.SetActive(false);
        }

        if (GameManager.instance.dead == false)
        {
            Control();
        }

        if (GameManager.instance.dead == true)
        {
            anim.Play("MinerDead");
        }
	}

    void Control()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 positionLeft = rb.transform.position;
            positionLeft.x -= speed *Time.deltaTime;
            rb.MovePosition(positionLeft);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 positionRight = rb.transform.position;
            positionRight.x += speed * Time.deltaTime;
            rb.MovePosition(positionRight);
        }

        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x < Screen.width / 2)
            {
                Vector2 positionRight = rb.transform.position;
                positionRight.x -= speed * Time.deltaTime;
                rb.MovePosition(positionRight);
                GameManager.instance.started = true;
            }

            if (Input.mousePosition.x > Screen.width / 2)
            {
                Vector2 positionRight = rb.transform.position;
                positionRight.x += speed * Time.deltaTime;
                rb.MovePosition(positionRight);
                GameManager.instance.started = true;
            }
        }
    }
   
}
