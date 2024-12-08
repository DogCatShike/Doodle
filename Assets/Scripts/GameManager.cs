using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance{get; set;}
    public GameObject start;
    public GameObject over;
    
    void Awake()
    {
        Instance = this;
    }

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

    public void OnButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        start.SetActive(false);
        over.SetActive(false);
        Time.timeScale = 1;
    }
}
