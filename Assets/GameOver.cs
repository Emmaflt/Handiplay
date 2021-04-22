using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameOver : MonoBehaviour
{
   public string Menu;
   public GameObject settingsWindow;
   public GameObject menuGameOver;
   public GameObject optionFirstButton;
   public GameObject gameOverFirstButton;
   public string LevelToLoad;

   public void RestartGame ()
   {
       SceneManager.LoadScene(LevelToLoad);
   }

   public void BackToMenuGameOver ()
   {
       if (menuGameOver.activeInHierarchy)
       {
           EventSystem.current.SetSelectedGameObject(null);
           EventSystem.current.SetSelectedGameObject(gameOverFirstButton);
       }
   }

   public void CloseSettingsWindow () 
   {
       settingsWindow.SetActive(false);
       menuGameOver.SetActive(true);
       BackToMenuGameOver();
   }

   public void SettingsButtons ()
   {
       settingsWindow.SetActive(true);
       menuGameOver.SetActive(false);
       EventSystem.current.SetSelectedGameObject(null);
       EventSystem.current.SetSelectedGameObject(optionFirstButton);
   }

   public void BackToMenu ()
   {
       SceneManager.LoadScene(Menu);
   }

}
