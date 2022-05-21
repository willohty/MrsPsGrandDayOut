using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterGoalZone : MonoBehaviour
{
    //The following is for updating the UI
    public Collectables collect;
    public CountAmountJars countjars;
    public GameObject haveNo;
    public GameObject haveYes;
    public GameObject persistantQuit;
    public GameObject winQuit;
    public TimerScript timer;

    public AudioSource victorysound;

    void Start()
    {
        haveNo.SetActive(false);
        haveYes.SetActive(false);

        winQuit.SetActive(false);

        GameObject g = GameObject.FindGameObjectWithTag("Player");
        
    }

    void OnTriggerEnter(Collider other)
    {
        //NOT A VICTORY
        if (collect.collectedCollectables < countjars.startAmountofJars)
        {
            if (other.tag == "Player")
            {
            haveNo.SetActive(true);
            }
        }
        
        //VICTORY AREA
        else
        {
            haveYes.SetActive(true);
            persistantQuit.SetActive(false);
            winQuit.SetActive(true);
            victorysound.Play();

            timer.TimerStop();
        }
    }
    void OnTriggerExit(Collider other)
    {
        haveNo.SetActive(false);
        haveYes.SetActive(false);
    }

    void Update()
    {

    }

}
