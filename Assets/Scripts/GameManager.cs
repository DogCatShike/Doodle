using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance{get; set;}
    public GameObject start;
    public GameObject over;

    public void GameStart()
    {
        Time.timeScale = 0;
        start.SetActive(true);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        over.SetActive(true);
    }

    public void OnStratButtonClick()
    {

    }

    public void OnOverButtonClick()
    {
        
    }
}
