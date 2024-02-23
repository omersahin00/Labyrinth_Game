using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneScriptController : MonoBehaviour
{
    void Start()
    {
        GameObject buttonPrefab;

        string controlButtonPosition = PlayerPrefs.GetString("SelectPosition", "Right");
        GameStatics.ButtonPosition = controlButtonPosition;

        if (controlButtonPosition.Equals("Right"))
        {
            buttonPrefab = Resources.Load<GameObject>("RightButtons");
        }
        else // controlButtonPosition -> "Left" olarak kabul edilecek.
        {
            buttonPrefab = Resources.Load<GameObject>("LeftButtons");
        }

        Instantiate(buttonPrefab);
    }
}
