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
    void Awake()
    {
        startListJars = GameObject.FindGameObjectsWithTag("Jar");
        startAmountofJars = startListJars.Length;
        print(startAmountofJars);
    }

    // Update is called once per frame
    void Update()
    {
        currentListJars = GameObject.FindGameObjectsWithTag("Jar");
        currentAmountofJars = currentListJars.Length;
    }
}
