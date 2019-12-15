using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public AudioClip suaraTombol ; 
    AudioSource audioSource;

    void Awake()
        {
            audioSource = GetComponent<AudioSource>();
        }

    public void LoadNextScene()
    {
        audioSource.clip = suaraTombol;
        audioSource.Play();
        DontDestroyOnLoad(audioSource);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1); /// akan bertambahah satu satu di build setting 
    }

    public void LoadStartScene()
    {
        audioSource.clip = suaraTombol;
        audioSource.Play();
        DontDestroyOnLoad(audioSource);
        SceneManager.LoadScene(0); /// akan di arah kan ke index 0 di build setting 
    }

    public void LoadLevel()
    {
        audioSource.clip = suaraTombol;
        audioSource.Play();
        DontDestroyOnLoad(audioSource);
        SceneManager.LoadScene(1);
    }

    public void LoadCredit()
    {
        audioSource.clip = suaraTombol;
        audioSource.Play();
        DontDestroyOnLoad(audioSource);
        SceneManager.LoadScene(6);
    }

    public void QuitGame()
    {
        Application.Quit(); /// digunakan untuk keluar dari game 
    }

    public void pindahstage()
    {
        audioSource.clip = suaraTombol;
        audioSource.Play();
        DontDestroyOnLoad(audioSource);
        SceneManager.LoadScene(4);
    }

    public void stage1()
    {
        audioSource.clip = suaraTombol;
        audioSource.Play();
        DontDestroyOnLoad(audioSource);
        SceneManager.LoadScene(1);
    }

    public void stage2()
    {
        audioSource.clip = suaraTombol;
        audioSource.Play();
        DontDestroyOnLoad(audioSource);
        SceneManager.LoadScene(2);
    }


}
