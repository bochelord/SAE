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
    public float faderDelay = 1.5f;
    public Button buttonPlay;
    public Button buttonQuit;
    public Image monsterImage;
    
    // Start is called before the first frame update
    void Start()
    {
        faderImage.DOFade(0, faderDelay).OnComplete(() => {
            if (showGraphyDebugConsole)
            {
                graphyDebug.SetActive(true);
            }
            
            //LoadIntro();
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
        faderImage.DOFade(1, faderDelay/2).OnComplete(() => {
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        });


    }


}
