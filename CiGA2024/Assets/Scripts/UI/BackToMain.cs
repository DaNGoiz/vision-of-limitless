using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMain : MonoBehaviour
{
    public void BackToMainScene()
    {
        UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync("SelectLevel");
    }
}
