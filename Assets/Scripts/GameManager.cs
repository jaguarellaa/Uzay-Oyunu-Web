using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.PlayerLoop;
using static UnityEngine.AudioSettings;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{

  
    public Move move;
    public Astronoat ast;
    public Spawner swnr;
    public int score=0;
    public int wordScore = 0;
    public int highScore = 0;
    public Text scoreText;
    public Text wordScoreText;
    public Text gameEndScoreText;
    public Text HighScoreText;

    public Button pause;
    public Button continuebtn;

    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
      
    }

   

    public void UpdateScore(int amount)
    {
        score+= amount;
        scoreText.text = score.ToString();
        gameEndScoreText.text = score.ToString();


        if(score > PlayerPrefs.GetInt("highScore"))
        {
           PlayerPrefs.SetInt("highScore", score);
        }

        
       
     
    }

    public void UpdateWordScore()
    {
        wordScore += 1;
        wordScoreText.text = wordScore.ToString();
     




    }



    private void Update()
    {
         HighScoreText.text = PlayerPrefs.GetInt("highScore").ToString();
    }

    public void MenuGame()
    {
        //SceneManager.LoadScene(0);
        Application.Quit();
        score = 0;
    }

    public void Retry()
    {
        SceneManager.LoadScene(1);
        score = 0;
        wordScore = 0;
    }
    
    public void Pause()
    {
        pause.gameObject.GetComponent<Image>().gameObject.SetActive(false);
        continuebtn.gameObject.GetComponent<Image>().gameObject.SetActive(true);
        pause.interactable = false;
        continuebtn.interactable = true;
        ast.aus[3].Stop();
        Time.timeScale=0;
    }

    public void Continue()
    {
        pause.gameObject.GetComponent<Image>().gameObject.SetActive(true);
        continuebtn.gameObject.GetComponent<Image>().gameObject.SetActive(false);
        continuebtn.interactable = false;
        pause.interactable = true;
        ast.aus[3].Play();

        Time.timeScale = 1;
    }

  
}

