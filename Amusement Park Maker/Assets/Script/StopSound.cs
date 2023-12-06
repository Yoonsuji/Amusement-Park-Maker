using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopSound : MonoBehaviour
{
    public GameObject BackgroundSound;
    public GameObject EffectSound;

    private AudioSource audioSource;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        audioSource = GetComponent<AudioSource>();
        button.onClick.AddListener(ToggleSound);
    }

    // Update is called once per frame
    void ToggleSound()
    {
        if(!audioSource.isPlaying)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
    }
}
