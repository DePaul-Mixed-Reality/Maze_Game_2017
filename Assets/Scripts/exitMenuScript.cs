using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class exitMenuScript : MonoBehaviour
{

    private static exitMenuScript instance = null;

    private static exitMenuScript GetInstance() { return instance; }

    //Canvas and Button are UI Objects
    public Canvas inGameExit;

    // Use this for initialization
    void Start()
    {
        inGameExit = inGameExit.GetComponent<Canvas>();
        inGameExit.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            inGameExit.enabled = true;
        }
    }

    //for when we click on "no"
    public void noPress()
    {
        inGameExit.enabled = false;
    }

    public void backToTitle()
    {
        setScene("MG_UIDemo");
    }

    public void setScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}