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

    // Start is called before the first frame update
    void Start()
    {
        faderImage.DOFade(0, 1.5f).OnComplete(() => {
            if (showGraphyDebugConsole)
            {
                graphyDebug.SetActive(true);
            }
            
            LoadIntro();
        });

    }


    private void LoadIntro()
    {

        //Fake delay
        faderImage.DOFade(0, 1f).OnComplete(() => {
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        });


    }


}
