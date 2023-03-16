using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay = .5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool once = true;

    void OnCollisionEnter2D(Collision2D other) 
    {
        FindObjectOfType<PlayerController>().DisableControls();
        if (once)
        {
            crashEffect.Play();
            once = false;
        }
        GetComponent<AudioSource>().Play();
        Invoke("ReloadScene", reloadDelay);
        once = true;
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
