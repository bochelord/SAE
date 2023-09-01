using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GameDataControllerSingleton : Singleton<GameDataControllerSingleton>
{

    public float playerLife;
    public RectTransform pausePanel;
    public RectTransform gameoverPanel;

    private bool game_paused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            PauseUnpause();
        }

        if (game_paused && Input.GetKeyDown(KeyCode.Q))
        {
            pausePanel.gameObject.SetActive(false);
            gameoverPanel.gameObject.SetActive(false);
            game_paused = false;
            Time.timeScale = 1;

            //fake delay
            pausePanel.transform.GetComponentInChildren<CanvasGroup>().DOFade(1, 0.15f).OnComplete(() => {
                ExitToMain();
            });

            

            
        }
    }


    public void PauseUnpause()
    {
        var isActive = pausePanel.gameObject.activeInHierarchy;
        pausePanel.gameObject.SetActive(!isActive);

        if (!game_paused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        game_paused = !game_paused;
    }

    public void ExitToMain()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }


    public void GameOver()
    {
        gameoverPanel.gameObject.SetActive(true);

    }

}
