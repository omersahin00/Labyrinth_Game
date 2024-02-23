using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishGameScript : MonoBehaviour
{
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();

        if (button.gameObject.name.Equals("Button-1"))
            button.onClick.AddListener(RestartGame);

        else if (button.gameObject.name.Equals("Button-2"))
            button.onClick.AddListener(ReturnMainMenu);
    }

    private void RestartGame()
    {
        SceneRoutingManager.RestartGame();
    }

    private void ReturnMainMenu()
    {
        SceneRoutingManager.ReturnMainMenu();
    }
}
