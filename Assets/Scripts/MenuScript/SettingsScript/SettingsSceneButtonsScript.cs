using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SettingsSceneButtonsScript : MonoBehaviour, IPointerDownHandler
{
    SettingsScript settingsScript;

    private void Start()
    {
        settingsScript = FindAnyObjectByType<SettingsScript>();
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        settingsScript.ButtonPressed(gameObject.name);
    }

}
