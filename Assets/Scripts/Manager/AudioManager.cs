using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("-----Audio Source-----")]
    [SerializeField] AudioSource _musicSource;
    [SerializeField] AudioSource _sfxSource;

   // [Header("-----Audio Clip-----")]
    //add audio reference
  // public AudioClip _bg;

    private void Start()
    {
        //_musicSource.clip = _bg;
       // _musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        _sfxSource.PlayOneShot(clip);
    }

    #region Notes
    //can add (AudioManager _audioManager;) to other scripts to active sound
    //private void Awake()
    //{
    //    _audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    //}
    //for a particular SFX you need add this within its function
    //_audioManager.PlaySFX(_audionManager. "pick a clip here");
    
    #endregion
}
