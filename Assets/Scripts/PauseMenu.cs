using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject PauseUI;
    public GameObject OptionMenu;
    private bool paused = false;
    private bool option = false;

    void Start()
    {
        PauseUI.SetActive(false);
        OptionMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            paused = !paused;
        }

        if (paused && option == false)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }

        if (!paused && option == false)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void OptionGameBack()
    {
        OptionMenu.SetActive(false);
        PauseUI.SetActive(true);
        option = false;
    }

    public void OptionGameGo()
    {
        option = true;
        PauseUI.SetActive(false);
        OptionMenu.SetActive(true);
    }

    public void ResumeGame()
    {
        Debug.Log("resume button");
        paused = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
