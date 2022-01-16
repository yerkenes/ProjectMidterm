using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sc : MonoBehaviour
{
   public void PlayGame()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
   }
   public void PlayAgain()
   {
       SceneManager.LoadScene(1);
   }
   public void ExitGame(){
       Debug.Log("EXIT!");
       Application.Quit();
   }
}
