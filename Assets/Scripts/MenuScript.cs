using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    //Canvas and Button are UI Objects
    public Canvas quitMenu;
    public Image startText;
    public Image exitText;
    public Canvas exitWindow;

	// Use this for initialization
	void Start () {
        //quitMenu = quitMenu.GetComponent<Canvas>();
        exitWindow = exitWindow.GetComponent<Canvas>();
        startText = startText.GetComponent<Image>();
        exitText = exitText.GetComponent<Image>();
        exitWindow.enabled = false;
    }

    public void exitPress()
    {
        //quitMenu.enabled = true;
        exitWindow.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
    }

    //for when we click on "no"
    public void noPress()
    {
        exitWindow.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
    }

    public void startLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void exitGame()
    {
        Application.Quit();
    }
    
}
