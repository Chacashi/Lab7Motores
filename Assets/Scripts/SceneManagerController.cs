using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerController : MonoBehaviour
{
    public string SceneName;
    public Button myButton;

    private void Awake()
    {
        myButton = GetComponent<Button>();
    }

    private void Start()
    {
        myButton.onClick.AddListener(() => LoadScene());
    }
    private void LoadScene()
    {
        SceneManager.LoadScene(SceneName);        
    }

   


}
