using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    public GameObject gameOverCanvas,CanvasStart,ScoreCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        Score.score = 0;
        ScoreCanvas.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver(){
        
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        Score.score = addScore.current_score;
    }

    public void replay(){
        SceneManager.LoadScene(1);
        CanvasStart.SetActive(true);
    }

    public void tapToStart(){
        Time.timeScale = 1;
        CanvasStart.SetActive(false);
        ScoreCanvas.SetActive(true);
    }
}
