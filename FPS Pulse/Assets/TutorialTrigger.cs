using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTrigger : MonoBehaviour
{
    public GameObject tutorialUI;
    public GameObject self;
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;

    void OnTriggerEnter(Collider other)
    {
        tutorialUI.SetActive(true);
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(5);

        tutorialUI.SetActive(false);
        audioSource.Stop();
        audioSource.PlayOneShot(audioClipArray[0]);
        self.SetActive(false);
    }
}
