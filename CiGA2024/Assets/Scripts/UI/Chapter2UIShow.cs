using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter2UIShow : MonoBehaviour
{
    public GameObject chapterName;
    public GameObject chapterNo;
    void Start()
    {
        if (PlayerPrefs.GetInt("maxLevelIndex") > 17)
        {
            chapterName.SetActive(true);
            chapterNo.SetActive(true);
        }
        else
        {
            chapterName.SetActive(false);
            chapterNo.SetActive(false);
        }
    }

}
