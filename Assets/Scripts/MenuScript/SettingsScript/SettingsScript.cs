using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsScript : MonoBehaviour
{
    public Button leftSelectButton;
    public Button rightSelectButton;

    Color whiteColor = new Color(1.0f, 1f, 1f, 1f);
    Color orangeColor = new Color(1.0f, 0.5f, 0.0f, 1f);

    void Start()
    {
        string selectPosition = PlayerPrefs.GetString("SelectPosition");

        if (selectPosition.Length == 0)
        {
            PlayerPrefs.SetString("SelectPosition", "Right");
            GameStatics.ButtonPosition = "Right";
            selectPosition = GameStatics.ButtonPosition;
        }

        PositionButtonEdit(selectPosition);
    }



    public void ButtonPressed(string ButtonName)
    {
        if (!ButtonName.Contains("Button"))
        {
            Debug.LogWarning("Bu bir buton değil!");
            return;
        }

        if (ButtonName.Contains("Select"))
        {
            if (ButtonName.Contains("Right"))
                PositionButtonEdit("Right");

            else if (ButtonName.Contains("Left"))
                PositionButtonEdit("Left");
        }

        else if (ButtonName.Contains("Close"))
        {
            SceneManager.LoadScene("Scene-0");
        }
    }


    private void PositionButtonEdit(string selectPosition)
    {
        if (selectPosition == "Right")
        {
            PlayerPrefs.SetString("SelectPosition", "Right");
            GameStatics.ButtonPosition = "Right";
            ChangeButtonColor(leftSelectButton, whiteColor);
            ChangeButtonColor(rightSelectButton, orangeColor);
        }
        else if (selectPosition == "Left")
        {
            PlayerPrefs.SetString("SelectPosition", "Left");
            GameStatics.ButtonPosition = "Left";
            ChangeButtonColor(leftSelectButton, orangeColor);
            ChangeButtonColor(rightSelectButton, whiteColor);
        }
        else Debug.LogWarning("Yön seçimlerin bir hata var!");
    }


    private void ChangeButtonColor(Button button, Color newColor)
    {
        ColorBlock colorBlock = button.colors;
        colorBlock.normalColor = newColor;
        colorBlock.selectedColor = newColor;
        button.colors = colorBlock;
    }
}
