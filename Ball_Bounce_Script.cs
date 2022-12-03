using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Random = UnityEngine.Random;
using Debug = UnityEngine.Debug;
using System.Security.Cryptography;
using UnityEngine.UI;

public class Ball_Bounce_Script : MonoBehaviour
{
    public Rigidbody rb;
    public int score;
    public Text myText = null;
    public Text scoreboard = null;
    public GameObject GameOverUI;
    public GameObject PauseMenuUI;
    public GameObject SettingsUI;
    public GameObject Ball;
    public GameObject Platform;

    void Start()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody>();
        score = 0;
        GameOverUI.SetActive(false);
        rb.velocity = new Vector3(0,0,0);
        rb.isKinematic = true;
        Ball.transform.position = new Vector3(0f, 5f, 0f);
        rb.isKinematic = false;
        Platform.transform.position = new Vector3(0f, -4f, 0f);
    }

    void FixedUpdate()
    {
        float x, y, z;
        x = Random.Range(-10.0f, 10.0f);
        z = Random.Range(-10.0f, 10.0f);
        y = Random.Range(-10.0f, 10.0f);
        rb.AddForce(x, y, z);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            //Debug.Log("Game Over!");
            gameOverFunct();

        }

        if (collision.gameObject.name == "platform")
        {
            score = score + 1;
            myText.text = "Score: " + score;

            //Debug.Log(score);
        }
    }

    void gameOverFunct()
    {
        PauseMenuUI.SetActive(false);
        SettingsUI.SetActive(false);
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
        scoreboard.text = "Your Score was " + score + ".";

    }

    public void retry()
    {
        PauseMenuUI.SetActive(false);
        SettingsUI.SetActive(false);
        GameOverUI.SetActive(false);
        Time.timeScale = 1f;
        Start();
    }
}
