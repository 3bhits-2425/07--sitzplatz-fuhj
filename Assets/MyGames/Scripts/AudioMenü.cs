using System.Collections;

using System.Collections.Generic;

using TMPro;

using UnityEngine;

public class AudioMenu : MonoBehaviour

{

    [SerializeField] private AudioSource myAudioSource;

    private TMP_Text playPauseButtonText;

    private GameObject playPauseButton;

    void Awake()

    {

        myAudioSource = GetComponent<AudioSource>();

        //1. Finde das Textfeld des PlayPause-Buttons

        playPauseButton = GameObject.Find("Pause/Play");

        //2. Finde das Textfeld als Kind des Buttons

        playPauseButtonText = playPauseButton.GetComponentInChildren<TMP_Text>();

    }

    public void PlayAudio()

    {

        // Spiele die Audio-Source 

        myAudioSource.Play();

    }

    public void PauseAudio()

    {

        // Pausiere die Audio-Source

        myAudioSource.Pause();

    }

    public void StopAudio()

    {

        // Stoppe die Audio-Source

        myAudioSource.Stop();

    }

    public void PlayPause()

    {

        if (myAudioSource.isPlaying)

        {

            myAudioSource.Pause();

   

        }

        else

        {

            myAudioSource.Play();

          

        }

    }

    public void Update()

    {

        //Ändere den Button-Text

        //abhängig vom Zusatnd der AusioSource

        if (myAudioSource.isPlaying)

        {

            playPauseButtonText.text = "Pause";
            Debug.Log("Audio is playing");
            //myAudioSource.Play();

        }

        else

        {

            playPauseButtonText.text = "Play";
            Debug.Log("Audio is paused");
            //myAudioSource.Pause();

        }

    }

}

