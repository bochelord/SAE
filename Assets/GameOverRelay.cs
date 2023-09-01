using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverRelay : MonoBehaviour
{
    public void OnGameover(GameObject go)
    {
        FindObjectOfType<GameDataControllerSingleton>().GameOver();
        Debug.Log("DEAAAD!!!!!");
    }
}
