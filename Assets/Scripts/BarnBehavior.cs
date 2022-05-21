using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarnBehavior : MonoBehaviour
{
    private Animator anim;
    public Collectables Collectables;

    void Start()
    {
        anim = GetComponent<Animator>();

       // One way of fetching a script off an object
       // Collectables = GameObject.Find("Collectables").GetComponent<Collectables>();
    }

    void Update()
    {
        if (Collectables.collectedCollectables == 6)
        {

            anim.SetBool("toOpen", true);
        }
    }
}