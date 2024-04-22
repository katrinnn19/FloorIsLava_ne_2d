using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour
{
    public GameObject menu;
    public void UnPauseGame()
    {
        menu.SetActive(false);
        Time.timeScale = 1f;
    }
}
