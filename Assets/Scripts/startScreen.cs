using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScreen : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject pauseScreen;
    public GameObject startScreenUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void startGame()
    {
        startScreenUI.SetActive(false);
    }
    public void quitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {

        Time.timeScale = 0;
        AudioListener.volume = 1;

        pauseScreen.SetActive(true);

    }
    public void Resume()
    {
        Time.timeScale = 1;
        AudioListener.volume = 1;// Unpause the game
        pauseScreen.SetActive(false);

    }
}
