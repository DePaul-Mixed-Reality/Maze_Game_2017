using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{ 
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if ((collider.gameObject.name == "player") && (KeyCount.numKeys>=1))
        {
            KeyCount.numKeys--;
            Destroy(gameObject);
            //set key text
        }
    }
}

