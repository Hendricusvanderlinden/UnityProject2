using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauzeMenuScript : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game1");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("The player has quit");
    }
}