using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuUI : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void NormalPlayer()
    {
        DataManager.Instance.SaveDataToFile("normal");
    }

    public void FirePlayer()
    {
        DataManager.Instance.SaveDataToFile("fire");
    }
}
