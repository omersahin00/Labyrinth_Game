using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGameSceneScript : MonoBehaviour
{
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(StartGame);

        string selectPosition = PlayerPrefs.GetString("SelectPosition", "Right");
        GameStatics.ButtonPosition = selectPosition;
    }

    private void StartGame()
    {
        SceneRoutingManager.ChangeScene();
    }
}
