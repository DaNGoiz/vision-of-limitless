using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUIShow : MonoBehaviour
{
    public GameObject[] levelUI;

    void Awake()
    {
        if (!PlayerPrefs.HasKey("maxLevelIndex"))
        {
            PlayerPrefs.SetInt("maxLevelIndex", 0);
        }
    }
    
    void Start()
    {
        int level = PlayerPrefs.GetInt("maxLevelIndex");
        for (int i = 0; i <= level; i++)
        {
            levelUI[i].SetActive(true);
        }
        if(level < levelUI.Length)
        {
            for (int i = level+1; i < levelUI.Length; i++)
            {
                levelUI[i].SetActive(false);
            }
        }
    }

}
