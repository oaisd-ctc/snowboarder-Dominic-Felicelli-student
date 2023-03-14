using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay = .5f;
    [SerializeField] ParticleSystem crashEffect;

    void OnCollisionEnter2D(Collision2D other) 
    {
        crashEffect.Play();
        Invoke("ReloadScene", reloadDelay);
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
