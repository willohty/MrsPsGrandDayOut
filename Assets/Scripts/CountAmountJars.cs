using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountAmountJars : MonoBehaviour
{
    public GameObject[] startListJars;
    public GameObject[] currentListJars;
    public int startAmountofJars;
    public int currentAmountofJars;
    // Start is called before the first frame update
    void Start()
    {
        startListJars = GameObject.FindGameObjectsWithTag("Jar");
        updateStartAmount(startListJars.Length);
        
    }

    // Update is called once per frame
    void Update()
    {
        currentListJars = GameObject.FindGameObjectsWithTag("Jar");
        currentAmountofJars = currentListJars.Length;
    }

    private void updateStartAmount(int given)
    {
        startAmountofJars = given;
    }
    public int returnStartAmount()
    {
        return startAmountofJars;
    }

    public int returnCurrentAmount()
    {
        return currentAmountofJars;
    }
}
