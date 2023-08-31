using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class StartupController : MonoBehaviour
{

    public Image faderImage;
    public GameObject graphyDebug;
    public bool showGraphyDebugConsole;
    public float faderDelay = 4f;
    public Button buttonPlay;
    public Button buttonQuit;
    public Image monsterImage;

    public GameObject creditsPanel;

    public CanvasGroup buttonCanvasGroup;
    public CanvasGroup titleCanvasGroup;
    
    // Start is called before the first frame update
    void Start()
    {

        buttonCanvasGroup.alpha = 0;

        titleCanvasGroup.alpha = 0;
        if (!faderImage.IsActive())
        {
            faderImage.gameObject.SetActive(true);
        }

        faderImage.DOFade(1, 2).OnComplete(() => {

            faderImage.DOFade(0, faderDelay).OnComplete(() => {
                if (showGraphyDebugConsole)
                {
                    graphyDebug.SetActive(true);
                }

                titleCanvasGroup.DOFade(1, faderDelay).OnComplete(() => {
                    buttonCanvasGroup.DOFade(1, faderDelay);
                });

            });

        });

        //subscribe to buttons
        buttonPlay.onClick.AddListener(() => {
            LoadIntro();
        });

        buttonQuit.onClick.AddListener(() => {
            Application.Quit();
        });


        monsterImage.transform.DOScale(1.5f, 0.025f).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.Linear).SetSpeedBased();
    }

    private void LoadIntro()
    {

        //Fake delay
        faderImage.DOFade(1, faderDelay).OnComplete(() => {
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        });


    }

    public void CloseCredits()
    {
        creditsPanel.gameObject.SetActive(false);
    }

    public void ShowCredits()
    {
        creditsPanel.gameObject.SetActive(true);
    }
}
