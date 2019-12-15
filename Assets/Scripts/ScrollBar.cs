using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBar : MonoBehaviour
{
    public GameObject scroll1, scroll2, scroll3, scroll4;
    public static int scroll = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (scroll > 4)
        {
            PlayerPrefs.SetInt("scroll", 0);
        }
        LoadScroll();
        scroll1.gameObject.SetActive(false);
        scroll2.gameObject.SetActive(false);
        scroll3.gameObject.SetActive(false);
        scroll4.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(scroll);
        switch (scroll)
        {
            case 1:
                scroll1.gameObject.SetActive(true);
                scroll2.gameObject.SetActive(false);
                scroll3.gameObject.SetActive(false);
                scroll4.gameObject.SetActive(false);
                break;
            case 2:
                scroll1.gameObject.SetActive(true);
                scroll2.gameObject.SetActive(true);
                scroll3.gameObject.SetActive(false);
                scroll4.gameObject.SetActive(false);
                break;
            case 3:
                scroll1.gameObject.SetActive(true);
                scroll2.gameObject.SetActive(true);
                scroll3.gameObject.SetActive(true);
                scroll4.gameObject.SetActive(false);
                break;
            case 4:
                scroll1.gameObject.SetActive(true);
                scroll2.gameObject.SetActive(true);
                scroll3.gameObject.SetActive(true);
                scroll4.gameObject.SetActive(true);
                break;
        }
    }

    public static int LoadScroll()
    {
        scroll = PlayerPrefs.GetInt("scroll");
        return scroll;
    }

    public static void SaveScroll(int score)
    {
        scroll += score;
        PlayerPrefs.SetInt("scroll", scroll);
    }
}
