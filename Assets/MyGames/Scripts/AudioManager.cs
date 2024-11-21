using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Klasse sound muss Serialisierbar sein


public class AudioManager : MonoBehaviour
{
    [SerializeField] private Sound[] sounds;

    private AudioManager singelton;


    void Awake()
    {
        if (singelton == null)
        {
            singelton = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);


        foreach (Sound oneSound in sounds)
        {
            oneSound.audioSource = gameObject.AddComponent<AudioSource>();
            oneSound.audioSource.clip = oneSound.clip;
            oneSound.audioSource.volume = oneSound.volume;
            oneSound.audioSource.pitch = oneSound.pitch;
        }
    }
    public void Play(string soundName)
    {
        //findAudio(soundName).audioSource.Play();
        //Debug.Log("Audio  (Audio Manager)");
        Sound mySound = findAudio(soundName);
        if (mySound != null)
        {
          Debug.Log("Sound"+ soundName+"Nicht gefunden");
          return;
        }

    }
    public void Pause(string soundName)
    {
        //findAudio(soundName).audioSource.Pause();
        //Debug.Log("Audio paused (Audio Manager)");
        Sound mySound = findAudio(soundName);
        if (mySound != null)
        {
            Debug.Log("Sound" + soundName + "Nicht gefunden");
            return;
        }


    }

    public Sound findAudio(string soundName)
    {
        foreach (Sound oneSound in sounds)
        {
            if (oneSound.name == soundName)
            {
                return oneSound;
            }
        }
        return null;
    }
}