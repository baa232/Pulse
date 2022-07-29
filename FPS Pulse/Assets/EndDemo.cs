using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDemo : MonoBehaviour
{
    public GameObject EndGameText;
    public GameObject EndGameText2;

    void OnTriggerEnter(Collider other)
    {
        EndGameText.SetActive(true);
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(5);

        EndGameText.SetActive(false);
        EndGameText2.SetActive(true);

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
