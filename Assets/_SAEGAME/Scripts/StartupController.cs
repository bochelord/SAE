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

    }


    


    private void LoadIntro()
    {

        //Fake delay
        faderImage.DOFade(1, faderDelay/2).OnComplete(() => {
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        });


    }


}
