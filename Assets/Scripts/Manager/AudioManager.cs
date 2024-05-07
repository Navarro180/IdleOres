using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("-----Audio Source-----")]
    [SerializeField] AudioSource _musicSource;
    [SerializeField] AudioSource _sfxSource;

    [Header("----- SFX Audio Clip-----")]
    //add audio reference
    //public AudioClip _bg;
    public AudioClip Mine;
    public AudioClip ore;
    public AudioClip rock;
    public AudioClip BugRelic;
    public AudioClip bone;
    public AudioClip Health;

    private void Start()
    {
       // _musicSource.clip = _bg;
       // _musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
       _sfxSource.PlayOneShot(clip);
    }

    #region Notes
    //make sure to create a tag Audio for the Audio Manager
    //can add (AudioManager _audioManager;) to other scripts to active sound
    //private void Awake()
    //{
    //    _audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    //}
    //for a particular SFX you need add this within its function
    //_audioManager.PlaySFX(_audionManager. "pick a clip here");
    
    #endregion
}
