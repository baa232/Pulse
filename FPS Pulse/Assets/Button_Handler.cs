using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button_Handler : MonoBehaviour
{
    public void SetText(string text)
    {
        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = text;
    }

    public void Resume()
    {
        Debug.Log("Resuming...");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlaySong()
    {
        Debug.Log("Playing Song...");
    }

    public void QuitSim()
    {
        Application.Quit();
        Debug.Log("Quiting game...");
    }
}
