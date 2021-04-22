using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class MainMenu : MonoBehaviour
{
    public string levelToLoad;
    public GameObject menuWindow;
    public GameObject settingsWindow;
    public GameObject creditsWindow;
    public GameObject menuFirstButton, optionFirstButton, optionClosedButton, creditsFirstButton;


    public void BackToMenuWindow ()
    {
        if (menuWindow.activeInHierarchy)
        {
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(menuFirstButton);
        }
    }

    public void StartGame () 
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void SettingsButtons () 
    {
        settingsWindow.SetActive(true);
        menuWindow.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionFirstButton);
    }

    public void CreditsButtons () 
    {
        creditsWindow.SetActive(true);
        menuWindow.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(creditsFirstButton);
    }

    public void CloseSettingsWindow ()
    {
        settingsWindow.SetActive(false);
        menuWindow.SetActive(true);
        BackToMenuWindow();
    }
    public void CloseCreditsWindow ()
    {
        creditsWindow.SetActive(false);
        menuWindow.SetActive(true);
        BackToMenuWindow();
    }

    public void QuitGame () 
    {
        Application.Quit();
    }
}