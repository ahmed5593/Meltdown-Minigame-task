using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager _instance;
    [HideInInspector] public int AI_AliveCount;
    [HideInInspector] public bool playerAlive = false;
    public GameObject levelWinPanel;
    public GameObject levelFailPanel;


    private void Awake()
    {
        _instance = this;
    }
    public void levelWin()
    {
        StartCoroutine(panelOpenDelayed(levelWinPanel, 1f));
    }

    public void LevelFail()
    {
        StartCoroutine(panelOpenDelayed(levelFailPanel, 1f));
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    IEnumerator panelOpenDelayed(GameObject go, float time)
    {
        yield return new WaitForSeconds(time);
        go.SetActive(true);
    }

    public void returnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }


}
