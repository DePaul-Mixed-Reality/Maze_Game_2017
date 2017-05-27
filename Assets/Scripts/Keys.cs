using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keys : MonoBehaviour {

    public Text keyText;

    void Start()
    {
        keyText = keyText.GetComponent<Text>();
        setKeyText();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "player")
        {
            KeyCount.numKeys++;
            Destroy(gameObject);
            setKeyText();
        }
    }

    void setKeyText()
    {
        keyText.text = KeyCount.numKeys.ToString();
    }
}
