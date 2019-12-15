using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SituasiAwal : MonoBehaviour
{
    public static void Normal()
    {
        PlayerPrefs.SetInt("health", 5);
        PlayerPrefs.SetInt("scroll", 0);
    }
}
