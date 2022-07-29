using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spri : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public AudioSource audioSource;
    public AudioClip[] audioClipArray;
    public int counter = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (counter == 0 || counter == 1 || counter == 2 || counter == 3)
            {
                audioSource.Stop();
                audioSource.PlayOneShot(audioClipArray[counter]);
            }

            if (counter < 3)
            {
                counter++;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(counter == 0 || counter == 1 || counter == 2 || counter == 3)
            {
                audioSource.Stop();
                audioSource.PlayOneShot(audioClipArray[counter]);
            }

            if (counter > 0)
            {
                counter--;
            }
        }

    }

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        GameObject player_ui_movement = GameObject.Find("Look Root");
        MouseLook playerScript = player_ui_movement.GetComponent<MouseLook>();
        playerScript.locked = true;
    }

    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

}
