using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitController : MonoBehaviour
{
    public Button myButton;
    private void Awake()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(() => OnClick());
    }

    void OnClick()
    {

        Application.Quit();
    }
}
