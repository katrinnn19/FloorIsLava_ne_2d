using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScene : MonoBehaviour
{
    public GameObject menu;
    public void PauseGame()
    {
        menu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }
    public void Awake()
    {
        PauseGame();
    }
}
