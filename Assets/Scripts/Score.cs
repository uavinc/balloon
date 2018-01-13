using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text scorePanel;
    public Text livesPanel;
    private int score = 0;
    public int lives;


    private void Awake ()
    {
        scorePanel.text = "Score:" + score;
        livesPanel.text = "Lives:" + lives;
    }
	
	public void addScore (int add)
    {
        score += add;
        scorePanel.text = "Score:" + score;
	}

    public void changeLives()
    {
        lives--;
        livesPanel.text = "Lives:" + lives;
    }

    public int getScore()
    {
        return score;
    }

    private void Update ()
    {
        if(lives <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if(score >= 100)
        {
            PlayerPrefs.SetInt("isWin",1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
