using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectables : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip collectableSound;
    public AudioClip collectJarSound;
    public AudioClip collectPossumSound;
    public Text Text_Collectables;
    public int collectedCollectables = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Text_Collectables.text = "Jars: " + collectedCollectables;
    }

    public void IncreaseCollectedCounter()
    {
        collectedCollectables++;
    }

    public void PlayCollectSounds()
    {
        audioSource.PlayOneShot(collectableSound, 0.25f);
        //audioSource.PlayOneShot(collectJarSound, 0.4f);
        
    }




}
