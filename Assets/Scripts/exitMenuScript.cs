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
    public Canvas quitMenu;

    // Use this for initialization
    void Start()
    {
        quitMenu = quitMenu.GetComponent<Canvas>();
        quitMenu.enabled = false;//starts game without quit menu
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            quitMenu.enabled = true;
        }
    }

    //for when we click on "no"
    public void noPress()
    {
        quitMenu.enabled = false;
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