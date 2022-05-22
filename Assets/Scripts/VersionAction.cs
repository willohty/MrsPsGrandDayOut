using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VersionAction : MonoBehaviour
{
    public Text versionText;
    public GameObject consistentQuit;
    public GameObject winQuit;
    public bool quitIsPresent = true;

    // Start is called before the first frame update
    void Start()
    {

        updateVersionText();

        if (VersionID.build=="webGL")
        {
            destroyQuitButtons();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateVersionText()
    {
        versionText.text = "version " + VersionID.build + " " + VersionID.number;
    }

    private void destroyQuitButtons()
    {
        quitIsPresent = false;
        print("hiding buttons");
        Destroy(winQuit);
        Destroy(consistentQuit);
    }
}
