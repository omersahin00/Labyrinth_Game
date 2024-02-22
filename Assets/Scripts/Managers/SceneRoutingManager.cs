using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneRoutingManager
{
    private static string activeSceneName { get; set; } = "Scene-0";
    private static int activeSceneNumber = 0;

    public static string ChangeScene()
    {
        try
        {
            int numberIndex = activeSceneName.IndexOf("-") + 1;
            if (numberIndex != -1)
            {
                int sceneNumber = int.Parse(activeSceneName.Substring(numberIndex));
                string sceneBaseName = activeSceneName.Substring(0, numberIndex);
                string newSceneName = sceneBaseName + ++sceneNumber;

                if (sceneNumber <= GameStatics.SceneCount)
                    SceneManager.LoadScene(newSceneName);
                else
                {
                    Debug.Log("Oyun bitti!");
                    SceneManager.LoadScene("Scene--1");
                    return "Scene--1";
                }

                activeSceneName = newSceneName;
                activeSceneNumber = sceneNumber;
                return activeSceneName;
            }
            else return "";
        }
        catch (System.Exception ex)
        {
            Debug.LogWarning("Bir sorun oluştu:" + ex);
            return null;
        }
    }

    private static void LoadActiveScene()
    {
        SceneManager.LoadScene(activeSceneName);
    }

    public static string GetActiveSceneName()
    {
        return activeSceneName;
    }

    public static int GetActiveSceneNumber()
    {
        return activeSceneNumber;
    }

    public static void RestartGame()
    {
        activeSceneName = "Scene-1";
        activeSceneNumber = 1;
        LoadActiveScene();
    }

    public static void ReturnMainMenu()
    {
        activeSceneName = "Scene-0";
        activeSceneNumber = 0;
        LoadActiveScene();
    } 
}
