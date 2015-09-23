using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

    public GameObject menuButtons;
    public GameObject confirmationBox;
    private Button yesButton;
    private Button noButton;

    private void Start() {
        if (confirmationBox)
        {
            yesButton = confirmationBox.transform.Find("yesButton").gameObject.GetComponent<Button>();
            noButton = confirmationBox.transform.Find("noButton").gameObject.GetComponent<Button>();
            yesButton.onClick.AddListener(confYes);
            noButton.onClick.AddListener(confNo);
        }
    }

    public void onClickPlay()
    {
        new sceneHandling().switchLevel("level01");
    }

    public void onClickExit()
    {
        if (confirmationBox)
        {
            if (menuButtons)
            {
                menuButtons.GetComponent<RectTransform>().localScale = new Vector3(1, 0, 1);
            }
            confirmationBox.GetComponent<RectTransform>().anchoredPosition = new Vector4(0, 0, 0);
        }
        else { Application.Quit();  }
    }

    private void confYes(){
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_WEBPLAYER
         Application.OpenURL(webplayerQuitURL);
        #else
            Application.Quit();
        #endif 
    }

    private void confNo(){
        confirmationBox.GetComponent<RectTransform>().anchoredPosition = new Vector4(0, 700, 0);
        if (menuButtons)
        {
            menuButtons.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        }
    }
}
