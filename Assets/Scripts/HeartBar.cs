using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartBar : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, heart4, heart5;
    public static int health = 5;
    // Start is called before the first frame update
    void Start()
    {
        LoadHealth();
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        heart4.gameObject.SetActive(true);
        heart5.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(health);
        switch (health)
        {
            case 5:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(true);
                heart5.gameObject.SetActive(true);
                break;
            case 4:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(true);
                heart5.gameObject.SetActive(false);
                break;
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;
            case 0:
                SceneManager.LoadScene("GameOver");
                SituasiAwal.Normal();
                break;
        }
    }

    public static int LoadHealth()
    {
        health = PlayerPrefs.GetInt("health");
        return health;
    }

    public static void SaveHealth(int hp)
    {
        health -= hp;
        PlayerPrefs.SetInt("health", health);
    }
}
