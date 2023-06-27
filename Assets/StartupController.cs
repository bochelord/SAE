using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class StartupController : MonoBehaviour
{

    public Image faderImage;
    public GameObject graphyDebug;

    // Start is called before the first frame update
    void Start()
    {
        faderImage.DOFade(0, 1.5f).OnComplete(() => {
            graphyDebug.SetActive(true);
        });

    }

    
}
