using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    

    public void LoadScene  ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }
    public void LoadGame1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1-1");
    }
    public void LoadNextLevel()
    {
        PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level")+1);
        SceneManager.LoadScene(PlayerPrefs.GetInt("Level") - 1);
    }
}
