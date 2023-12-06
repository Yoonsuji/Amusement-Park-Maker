using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickSound : MonoBehaviour
{
    public AudioClip clickSound;

    private Button button;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();

        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = clickSound;

        button.onClick.AddListener(PlayClickSound);
    }

    // Update is called once per frame
    void PlayClickSound()
    {
        audioSource.Play();
    }
}
